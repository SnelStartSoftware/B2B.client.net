using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SnelStart.B2B.Client.Operations
{
    internal class AuthenticationOperations : IAuthenticationOperations
    {
        private readonly HttpClient _httpClient;
        private readonly Config _config;

        public AuthenticationOperations(ClientState clientState)
        {
            _httpClient = clientState.HttpClient;
            _config = clientState.Config;
        }

        public async Task<LoginResponse> LoginAsync(string username, string password)
        {
            var requestBody = new Dictionary<string, string>
            {
                {"grant_type", "password"},
                {"username", username},
                {"password", password}
            };

            var message = await _httpClient.PostAsync(_config.AuthUri, new FormUrlEncodedContent(requestBody));
            var json = await message.Content.ReadAsStringAsync();

            var authResponse = JsonConvert.DeserializeObject<AuthResposne>(json);

            return new LoginResponse
            {
                AccessToken = authResponse.Access_Token,
                TokenType = authResponse.Token_Type,
                ExpiresIn = authResponse.Expires_In,
            };
        }

        private class AuthResposne
        {
            public string Access_Token { get; set; }
            public string Token_Type { get; set; }
            public int Expires_In { get; set; }
        }
    }
}