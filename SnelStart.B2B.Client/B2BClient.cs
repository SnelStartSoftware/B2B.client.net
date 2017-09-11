using System;
using System.Threading.Tasks;
using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client
{
    public class B2BClient : IB2BClient
    {
        private readonly ClientState _clientState;
        public string AccessToken { get { return _clientState.AccessToken; } }

        public IAuthenticationOperations Authentication { get; }
        public IKostenplaatsenOperations Kostenplaatsen { get; }
        public IGrootboekenOperations Grootboeken { get; }
        public ILandenOperations Landen { get; }
        public IMemoriaalboekingenOperations Memoriaalboekingen { get; }
        public IDagboekenOperations Dagboeken { get; }
        public IRelatiesOperations Relaties { get; }
        public IVerkoopboekingenOperations Verkoopboekingen { get; }

        public B2BClient(Config config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            _clientState = new ClientState(config);
            Authentication = new AuthenticationOperations(_clientState);
            Kostenplaatsen = new KostenplaatsenOperations(_clientState);
            Grootboeken = new GrootboekenOperations(_clientState);
            Landen = new LandenOperations(_clientState);
            Memoriaalboekingen = new MemoriaalboekingenOperations(_clientState);
            Dagboeken = new DagboekenOperations(_clientState);
            Relaties = new RelatiesOperations(_clientState);
            Verkoopboekingen = new VerkoopboekingenOperations(_clientState);
        }

        public async Task AuthorizeAsync()
        {
            var pair = _clientState.Config.GetApiUsernamePassword();

            var clientStateAccessToken = await Authentication.LoginAsync(pair.Username, pair.Password).ConfigureAwait(false);
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