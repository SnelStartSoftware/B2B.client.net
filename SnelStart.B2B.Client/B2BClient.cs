using System;
using System.Threading.Tasks;
using SnelStart.B2B.Client.Operations;
using SnelStart.B2B.Client.Operations.Kostenplaatsen;

namespace SnelStart.B2B.Client
{
    public class B2BClient : IB2BClient
    {
        private readonly ClientState _clientState;

        public IAuthenticationOperations Authentication { get; }
        public IKostenplaatsenOperations Kostenplaatsen { get; }

        public B2BClient(Config config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            _clientState = new ClientState(config);
            Authentication = new AuthenticationOperations(_clientState);
            Kostenplaatsen = new KostenplaatsenOperations(_clientState);
        }

        internal async Task AuthorizeAsync()
        {
            var pair = _clientState.Config.GetApiUsernamePassword();

            var clientStateAccessToken = await Authentication.LoginAsync(pair.Username, pair.Password);
            _clientState.AccessToken = clientStateAccessToken.AccessToken;

            _clientState.HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_clientState.AccessToken}");
            _clientState.HttpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _clientState.Config.SubscriptionKey);
        }

        public void Dispose()
        {
            _clientState.Dispose();
        }
    }
}