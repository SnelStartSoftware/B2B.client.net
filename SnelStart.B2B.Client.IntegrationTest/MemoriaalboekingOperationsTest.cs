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
        protected override MemoriaalboekingModel CreateNewModel()
        {
            return new MemoriaalboekingModel
            {
          
            };
        }
    }
}