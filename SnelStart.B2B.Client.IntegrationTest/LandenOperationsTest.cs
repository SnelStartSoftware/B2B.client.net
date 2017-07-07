using System.Linq;
using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnelStart.B2B.Client.IntegrationTest
{
    [TestFixture]
    public class LandenOperationsTest 
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
            var result = await _client.Landen.GetAllAsync();

            Assert.AreEqual(HttpStatusCode.OK, result.HttpStatusCode);
        }

        [Test]
        public async Task GetByIdAsync()
        {
            var getAllResult = await _client.Landen.GetAllAsync();
            var first = getAllResult.Result.FirstOrDefault();
            if (first == null)
            {
                Assert.Inconclusive("No land available");
            }
            var result = await _client.Landen.GetByIdAsync(first.Id);

            Assert.AreEqual(HttpStatusCode.OK, result.HttpStatusCode);
        }
    }
}