using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnelStart.B2B.Client.IntegrationTest
{
    [TestFixture]
    public class AuthenticationOperationsTest
    {
        private B2BClient _client;
        private Config _config;

        [SetUp]
        public void Setup()
        {
            _client = DependencyRoot.Client;
            _config = DependencyRoot.Config;
        }

        [Test]
        public async Task LoginAsync()
        {
            var pair = _config.GetApiUsernamePassword();

            var result = await _client.Authentication.LoginAsync(pair.Username, pair.Password);

            Assert.IsNotEmpty(result.AccessToken);
            Assert.AreEqual("bearer", result.TokenType);
        }
    }
}
