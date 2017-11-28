using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client.IntegrationTest
{
    [TestFixture]
    public class MemoriaalboekingOperationsTest : CrudTest<MemoriaalboekingModel>
    {
        private B2BClient _client;

        [SetUp]
        public void Setup()
        {
            _client = DependencyRoot.Client;
        }
        protected override ICrudOperations<MemoriaalboekingModel> CrudSubject => _client.Memoriaalboekingen;
        protected override async Task<MemoriaalboekingModel> CreateNewModelAsync()
        {
            var grootboeken = await _client.Grootboeken.GetAllAsync();
            var grootboek = grootboeken.Result.FirstOrDefault(x => x.RekeningCode == RekeningCodeModel.Balans);

            if (grootboek == null)
            {
                Assert.Inconclusive("No grootboek with RekeningCode RekeningCodeModel.Balans available");
            }


            var kostenplaatsen = await _client.Kostenplaatsen.GetAllAsync();
            var kostenplaats = kostenplaatsen.Result.FirstOrDefault();
            if (kostenplaats == null)
            {
                Assert.Inconclusive("No kostenplaats available");
            }

            var dagboeken = await _client.Dagboeken.GetAllAsync();
            var dagboek = dagboeken.Result.FirstOrDefault(x => x.Soort == DagboekSoortModel.Memoriaal);
            if (dagboek == null)
            {
                Assert.Inconclusive("No dagboek with Soort DagboekSoortModel.Memoriaal available ");
            }

            return new MemoriaalboekingModel
            {
                Omschrijving = Guid.NewGuid().ToString(),
                Datum = DateTime.UtcNow,
                Dagboek = new DagboekIdentifierModel
                {
                    Id = dagboek.Id
                },
                MemoriaalBoekingsRegels = new[]
                {
                    new MemoriaalboekingModel.MemoriaalBoekingsRegelModel
                    {
                        Grootboek = grootboek,
                        Omschrijving = Guid.NewGuid().ToString(),
                        Credit = 1,
                        Kostenplaats = kostenplaats
                    },
                    new MemoriaalboekingModel.MemoriaalBoekingsRegelModel
                    {
                        Grootboek = grootboek,
                        Omschrijving = Guid.NewGuid().ToString(),
                        Credit = -1,
                        Kostenplaats = kostenplaats
                    }
                }
            };
        }
    }
}