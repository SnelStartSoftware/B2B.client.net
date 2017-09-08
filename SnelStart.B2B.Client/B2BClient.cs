using System;
using System.Threading.Tasks;
using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client
{
    public class B2BClient : IB2BClient
    {
        public readonly ClientState clientState;

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

            clientState = new ClientState(config);
            Authentication = new AuthenticationOperations(clientState);
            Kostenplaatsen = new KostenplaatsenOperations(clientState);
            Grootboeken = new GrootboekenOperations(clientState);
            Landen = new LandenOperations(clientState);
            Memoriaalboekingen = new MemoriaalboekingenOperations(clientState);
            Dagboeken = new DagboekenOperations(clientState);
            Relaties = new RelatiesOperations(clientState);
            Verkoopboekingen = new VerkoopboekingenOperations(clientState);
        }

        public async Task AuthorizeAsync()
        {
            var pair = clientState.Config.GetApiUsernamePassword();

            var clientStateAccessToken = await Authentication.LoginAsync(pair.Username, pair.Password).ConfigureAwait(false);
            clientState.AccessToken = clientStateAccessToken.AccessToken;

            clientState.HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {clientState.AccessToken}");
            clientState.HttpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", clientState.Config.SubscriptionKey);
        }

        public void Dispose()
        {
            clientState.Dispose();
        }
    }
}