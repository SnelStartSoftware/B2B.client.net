using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client
{

    internal class ClientState : IDisposable
    {
        private static readonly HttpClient HttpClient = new HttpClient();

        public Config Config { get; }
        public string AccessToken { get; internal set; }
        public DateTime RenewTokenBefore { get; set; }

        public ClientState(Config config)
        {
            Config = config;
        }

        public async Task AuthorizeAsync()
        {
            var pair = Config.GetApiUsernamePassword();

            var requestBody = new Dictionary<string, string>
            {
                {"grant_type", "password"},
                {"username", pair.Username},
                {"password", pair.Password}
            };

            var message = await HttpClient.PostAsync(Config.AuthUri, new FormUrlEncodedContent(requestBody)).ConfigureAwait(false);
            var json = await message.Content.ReadAsStringAsync().ConfigureAwait(false);

            var authResponse = JsonConvert.DeserializeObject<AuthResposne>(json);

            AccessToken = authResponse.Access_Token;
            RenewTokenBefore = DateTime.UtcNow.AddSeconds(authResponse.Expires_In);

            HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {AccessToken}");
            HttpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Config.SubscriptionKey);
        }

        public Task<Response<T>> ExecutePostAsync<T>(string resourceName, T dto) => ExecutePostAsync<T, T>(resourceName, dto);


        public async Task<Response<TResponse>> ExecutePostAsync<TDto, TResponse>(string relativeUri, TDto dto)
        {
            await EnsureAuthorizedAsync().ConfigureAwait(false);

            var resourceUri = Config.ApiBaseUriVersioned.AddSegment(relativeUri);
            var requestBody = JsonConvert.SerializeObject(dto);

            return await Execute(async httpClient =>
            {
                var response = await httpClient.PostAsync(resourceUri, new StringContent(requestBody, Encoding.UTF8, "application/json")).ConfigureAwait(false);
                return await CreateResponse<TResponse>(response, HttpStatusCode.Created).ConfigureAwait(false);
            }).ConfigureAwait(false);
        }



        public async Task<Response<T>> ExecutePutAsync<T>(string resourceName, T dto) where T : IIdentifierModel
        {
            await EnsureAuthorizedAsync().ConfigureAwait(false);

            var resourceUri = Config.ApiBaseUriVersioned.AddSegment(resourceName);
            var requestBody = JsonConvert.SerializeObject(dto);

            var itemUri = resourceUri.AddSegment(dto.Id);
            return await Execute(async httpClient =>
            {
                var response = await httpClient.PutAsync(itemUri, new StringContent(requestBody, Encoding.UTF8, "application/json")).ConfigureAwait(false);
                return await CreateResponse<T>(response, HttpStatusCode.OK).ConfigureAwait(false);
            }).ConfigureAwait(false);
        }

        public async Task<Response<T[]>> ExecuteGetAllAsync<T>(string resourceName) where T : IIdentifierModel
        {
            await EnsureAuthorizedAsync().ConfigureAwait(false);

            var resourceUri = Config.ApiBaseUriVersioned.AddSegment(resourceName);

            return await Execute(async httpClient =>
            {
                var response = await httpClient.GetAsync(resourceUri);
                return await CreateResponse<T[]>(response, HttpStatusCode.OK);
            }).ConfigureAwait(false);
        }

        public async Task<Response<T[]>> ExecuteGetAsync<T>(string resourceName, string queryString) where T : IIdentifierModel
        {
            await EnsureAuthorizedAsync().ConfigureAwait(false);

            var resourceUri = Config.ApiBaseUriVersioned.AddSegment(resourceName);

            return await Execute(async httpClient =>
            {
                var response = await httpClient.GetAsync(resourceUri + "?" + queryString);
                return await CreateResponse<T[]>(response, HttpStatusCode.OK);
            }).ConfigureAwait(false);
        }

        private async Task<Response<TData>> CreateResponse<TData>(HttpResponseMessage response, HttpStatusCode expectedStatusCode)
        {
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.StatusCode == expectedStatusCode)
            {
                var result = JsonConvert.DeserializeObject<TData>(body);
                return new Response<TData>
                {
                    Result = result,
                    HttpStatusCode = response.StatusCode,
                    ResponseBody = body
                };
            }
            return new Response<TData>
            {
                HttpStatusCode = response.StatusCode,
                ResponseBody = body
            };
        }

        public async Task<Response<T>> ExecuteGetByIdAsync<T>(string resourceName, Guid id) where T : IIdentifierModel
        {
            await EnsureAuthorizedAsync().ConfigureAwait(false);

            var resourceUri = Config.ApiBaseUriVersioned.AddSegment(resourceName);
            var itemUri = resourceUri.AddSegment(id);

            return await Execute(async httpClient =>
            {
                var response = await httpClient.GetAsync(itemUri);
                return await CreateResponse<T>(response, HttpStatusCode.OK);
            }).ConfigureAwait(false);
        }

        public async Task<Response> ExecuteDeleteAsync(string resourceName, Guid id)
        {
            await EnsureAuthorizedAsync().ConfigureAwait(false);

            var resourceUri = Config.ApiBaseUriVersioned.AddSegment(resourceName);
            var itemUri = resourceUri.AddSegment(id);

            return await Execute(async httpClient =>
            {
                var response = await httpClient.DeleteAsync(itemUri);
                var body = await response.Content.ReadAsStringAsync();
                return new Response
                {
                    HttpStatusCode = response.StatusCode,
                    ResponseBody = body
                };
            }).ConfigureAwait(false);
        }

        private async Task EnsureAuthorizedAsync()
        {
            if (AccessToken == null || RenewTokenBefore < DateTime.UtcNow)
            {
                await AuthorizeAsync();
            }
        }

        private async Task<TResult> Execute<TResult>(Func<HttpClient, Task<TResult>> action)
        {
            return await action(HttpClient).ConfigureAwait(false);
        }

        public void Dispose()
        {
            HttpClient.Dispose();
        }

        private class AuthResposne
        {
            public string Access_Token { get; set; }
            public string Token_Type { get; set; }
            public int Expires_In { get; set; }
        }
    }
}