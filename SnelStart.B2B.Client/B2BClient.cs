using System;
using System.Net;
using System.Threading.Tasks;
using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client
{
    public class B2BClient : IB2BClient
    {
        private readonly ClientState _clientState;

        public string AccessToken => _clientState.AccessToken;

        public IKostenplaatsenOperations Kostenplaatsen { get; }
        public IGrootboekenOperations Grootboeken { get; }
        public ILandenOperations Landen { get; }
        public IMemoriaalboekingenOperations Memoriaalboekingen { get; }
        public IDagboekenOperations Dagboeken { get; }
        public IRelatiesOperations Relaties { get; }
        public IVerkoopboekingenOperations Verkoopboekingen { get; }
        public IVerkoopboekingBijlagesOperations VerkoopboekingBijlages { get; }
        public IVerkoopfacturenOperations Verkoopfacturen { get; }
        public IBankboekingenOperations Bankboekingen { get; }
        public IBankafschriftBestandenOperations BankafschriftBestanden { get; }

        public B2BClient(Config config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            _clientState = new ClientState(config);

            Kostenplaatsen = new KostenplaatsenOperations(_clientState);
            Grootboeken = new GrootboekenOperations(_clientState);
            Landen = new LandenOperations(_clientState);
            Memoriaalboekingen = new MemoriaalboekingenOperations(_clientState);
            Dagboeken = new DagboekenOperations(_clientState);
            Relaties = new RelatiesOperations(_clientState);
            Verkoopboekingen = new VerkoopboekingenOperations(_clientState);
            VerkoopboekingBijlages = new VerkoopboekingBijlagesOperations(_clientState);
            Verkoopfacturen = new VerkoopfacturenOperations(_clientState);
            Bankboekingen = new BankboekingenOperations(_clientState);
            BankafschriftBestanden = new BankafschriftBestandenOperations(_clientState);
        }

        public void Dispose()
        {
            
        }

        public async Task AuthorizeAsync()
        {
            await _clientState.AuthorizeAsync().ConfigureAwait(false);
        }
    }
}