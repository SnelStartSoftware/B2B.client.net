using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnelStart.B2B.Client.IntegrationTest
{
    [TestFixture]
    public class GrootboekenOperationsTest
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
            var result = await _client.Grootboeken.GetAllAsync();

            Assert.AreEqual(HttpStatusCode.OK, result.HttpStatusCode);
        }

        [Test]
        public async Task Filter_EmptyOmchrijving()
        {
            var result = await _client.Grootboeken.GetAsync("$filter=Omschrijving eq ''");

            Assert.AreEqual(HttpStatusCode.OK, result.HttpStatusCode);
        }
    }
}