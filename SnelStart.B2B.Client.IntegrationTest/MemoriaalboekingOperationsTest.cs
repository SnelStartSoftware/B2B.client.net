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
            var grootboek = grootboeken.Result.FirstOrDefault();

            if (grootboek == null)
            {
                Assert.Inconclusive("No grootboek available");
            }


            var kostenplaatsen = await _client.Kostenplaatsen.GetAllAsync();
            var kostenplaats = kostenplaatsen.Result.FirstOrDefault();
            if (kostenplaats == null)
            {
                Assert.Inconclusive("No kostenplaats available");
            }

            return new MemoriaalboekingModel
            {
                Omschrijving = Guid.NewGuid().ToString(),
                Datum = DateTime.UtcNow,
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