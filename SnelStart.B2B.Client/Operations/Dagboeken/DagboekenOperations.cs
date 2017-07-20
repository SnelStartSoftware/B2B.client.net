using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    internal class DagboekenOperations : OperationsBase<DagboekModel>, IDagboekenOperations
    {
        public DagboekenOperations(ClientState clientState) : base(clientState, DagboekModel.ResourceName)
        {
        }

        public Task<Response<DagboekModel[]>> GetAllAsync() => base.ExecuteGetAllAsync();

    }
}