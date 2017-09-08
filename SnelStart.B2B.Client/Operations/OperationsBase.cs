using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SnelStart.B2B.Client.Operations
{
    internal abstract class OperationsBase<T> where T : IIdentifierModel
    {
        private readonly ClientState _clientState;
        private readonly Uri _resourceUri;

        protected OperationsBase(ClientState clientState, string resourceName)
        {
            _clientState = clientState;
            _resourceUri = _clientState.Config.ApiBaseUriVersioned.AddSegment(resourceName);
        }

        protected Task<Response<T>> ExecutePostAsync(T dto)
        {
            var requestBody = JsonConvert.SerializeObject(dto);

            return Execute(async httpClient =>
            {
                var response = await httpClient.PostAsync(_resourceUri, new StringContent(requestBody, Encoding.UTF8, "application/json")).ConfigureAwait(false);
                return await CreateResponse<T>(response, HttpStatusCode.Created).ConfigureAwait(false);
            });
        }
        protected Task<Response<T>> ExecutePutAsync(T dto)
        {
            var requestBody = JsonConvert.SerializeObject(dto);
            var itemUri = _resourceUri.AddSegment(dto.Id);
            return Execute(async httpClient =>
            {
                var response = await httpClient.PutAsync(itemUri, new StringContent(requestBody, Encoding.UTF8, "application/json")).ConfigureAwait(false);
                return await CreateResponse<T>(response, HttpStatusCode.OK).ConfigureAwait(false);
            });
        }

        protected async Task<Response<T[]>> ExecuteGetAllAsync()
        {
            return await Execute(async httpClient =>
            {
                var response = await httpClient.GetAsync(_resourceUri);
                return await CreateResponse<T[]>(response, HttpStatusCode.OK);
            }).ConfigureAwait(false);
        }
        protected async Task<Response<T[]>> ExecuteGetAsync(string queryString)
        {
            return await Execute(async httpClient =>
            {
                var response = await httpClient.GetAsync(_resourceUri+"?"+queryString);
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

        protected async Task<Response<T>> ExecuteGetByIdAsync(Guid id)
        {
            var itemUri = _resourceUri.AddSegment(id);
            return await Execute(async httpClient =>
            {
                var response = await httpClient.GetAsync(itemUri);
                return await CreateResponse<T>(response, HttpStatusCode.OK);
            }).ConfigureAwait(false);
        }

        protected async Task<Response> ExecuteDeleteAsync(Guid id)
        {
            var itemUri = _resourceUri.AddSegment(id);
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

        private async Task<TResult> Execute<TResult>(Func<HttpClient, Task<TResult>> action)
        {
            return await action(_clientState.HttpClient).ConfigureAwait(false);
        }
    }
}