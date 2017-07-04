using System;
using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;
using SnelStart.B2B.Client.Operations;
using SnelStart.B2B.Client.Operations.Kostenplaatsen;

namespace SnelStart.B2B.Client.IntegrationTest
{
    [TestFixture]
    public class KostenplaatsenOperationsTest
    {
        private B2BClient _client;

        [SetUp]
        public void Setup()
        {
            _client = DependencyRoot.Client;
        }

        [Test]
        public async Task GetAllAsync()
        {
            var result = await _client.Kostenplaatsen.GetAllAsync();

            Assert.AreEqual(HttpStatusCode.OK, result.HttpStatusCode);
        }

        [Test]
        public async Task DeleteAsync()
        {
            var createResponse = await SetupCreatedAsync();

            var deleteResponse = await _client.Kostenplaatsen.DeleteAsync(createResponse.Result.Id);
            var getByIdResponse = await _client.Kostenplaatsen.GetByIdAsync(createResponse.Result.Id);

            Assert.AreEqual(HttpStatusCode.OK, deleteResponse.HttpStatusCode);
            Assert.AreEqual(HttpStatusCode.NotFound, getByIdResponse.HttpStatusCode);
        }

        [Test]
        public async Task GetByIdAsync()
        {
            var createResponse = await SetupCreatedAsync();

            try
            {
                var getByIdResponse = await _client.Kostenplaatsen.GetByIdAsync(createResponse.Result.Id);
                Assert.AreEqual(HttpStatusCode.OK, getByIdResponse.HttpStatusCode);
            }
            finally
            {
                await _client.Kostenplaatsen.DeleteAsync(createResponse.Result.Id);
            }
        }

        [Test]
        public async Task UpdateAsync()
        {
            var createResponse = await SetupCreatedAsync();

            var createdModel = createResponse.Result;
            try
            {
                createdModel.Omschrijving = Guid.NewGuid().ToString();
                var updateResponse = await _client.Kostenplaatsen.UpdateAsync(createdModel);

                Assert.AreEqual(HttpStatusCode.OK, updateResponse.HttpStatusCode);
            }
            finally
            {
                await _client.Kostenplaatsen.DeleteAsync(createdModel.Id);
            }
        }

        private async Task<Response<KostenplaatsModel>> SetupCreatedAsync()
        {
            var dto = new KostenplaatsModel
            {
                Nummer = 1003,
                Omschrijving = Guid.NewGuid().ToString()
            };

            var createResponse = await _client.Kostenplaatsen.CreateAsync(dto);
            if (createResponse.HttpStatusCode != HttpStatusCode.Created)
            {
                Assert.Inconclusive("Kostenplaats not created");
            }
            return createResponse;
        }
    }
}