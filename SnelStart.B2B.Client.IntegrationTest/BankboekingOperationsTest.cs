using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client.IntegrationTest
{
    [TestFixture]
    public class BankboekingOperationsTest : CrudTest<BankboekingModel>
    {
        private B2BClient _client;

        [SetUp]
        public void Setup()
        {
            _client = DependencyRoot.Client;
        }
        protected override ICrudOperations<BankboekingModel> CrudSubject => _client.Bankboekingen;
        protected override async Task<BankboekingModel> CreateNewModelAsync()
        {
            var grootboeken = await _client.Grootboeken.GetAllAsync();
            var grootboek = grootboeken.Result.FirstOrDefault(x => x.GrootboekFunctie == GrootboekFunctieModel.Diversen);

            if (grootboek == null)
            {
                Assert.Inconclusive("No grootboek with Functie GrootboekFunctieModel.Diversen available");
            }

            var dagboeken = await _client.Dagboeken.GetAllAsync();
            var dagboek = dagboeken.Result.FirstOrDefault(x => x.Soort == DagboekSoortModel.Bank);
            if (dagboek == null)
            {
                Assert.Inconclusive("No dagboek with Soort DagboekSoortModel.Bank available ");
            }

            return new BankboekingModel
            {
                Omschrijving = Guid.NewGuid().ToString(),
                Datum = DateTime.UtcNow,
                Dagboek = new DagboekIdentifierModel
                {
                    Id = dagboek.Id
                },
                BedragOntvangen = 1,
                GrootboekBoekingsRegels = new[]
                {
                    new GrootboekBoekingsRegelModel
                    {
                        Omschrijving = "test",
                        Bedrag = 1,
                        Grootboek = new GrootboekIdentifierModel(grootboek.Id)
                    }
                }
            };
        }
    }
}