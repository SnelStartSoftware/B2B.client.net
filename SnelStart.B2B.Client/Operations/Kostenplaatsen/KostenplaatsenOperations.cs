using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations.Kostenplaatsen
{
    internal class KostenplaatsenOperations : CrudOperationsBase<KostenplaatsModel>, IKostenplaatsenOperations
    {
        public KostenplaatsenOperations(ClientState clientState)
            : base(clientState, "kostenplaatsen")
        {
        }

        public Task<Response<KostenplaatsModel[]>> GetAllAsync() => base.ExecuteGetAllAsync();
    }
}