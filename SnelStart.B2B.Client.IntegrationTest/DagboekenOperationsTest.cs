using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnelStart.B2B.Client.IntegrationTest
{
    [TestFixture]
    public class DagboekenOperationsTest
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
            var result = await _client.Dagboeken.GetAllAsync();

            Assert.AreEqual(HttpStatusCode.OK, result.HttpStatusCode);
        }
    }
}