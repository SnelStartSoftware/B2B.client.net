using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;
using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client.IntegrationTest
{
    [TestFixture]
    public class BankafschriftBestandenOperationsTest 
    {
        private B2BClient _client;

        [SetUp]
        public void Setup()
        {
            _client = DependencyRoot.Client;
        }

        [Test]
        public async Task ReadBankafschriftBestandenAsync()
        {
            var bankafschriftBestand = new BankafschriftBestand
            {
                Base64EncodedContent = "test",
                Name = "test.txt"
            };

            var response = await _client.BankafschriftBestanden.ReadBankafschriftBestandenAsync(new[]
            {
                bankafschriftBestand
            });

            
            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.Created));
            Assert.That(response.Result[0].IsSuccess, Is.False);
        }
    }
}