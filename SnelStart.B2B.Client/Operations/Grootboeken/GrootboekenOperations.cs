using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    internal class GrootboekenOperations : CrudOperationsBase<GrootboekModel>, IGrootboekenOperations
    {
        public GrootboekenOperations(ClientState clientState) : base(clientState, GrootboekModel.ResourceName)
        {
        }

        public Task<Response<GrootboekModel[]>> GetAllAsync() => base.ExecuteGetAllAsync();
        public Task<Response<GrootboekModel[]>> GetAsync(string queryString) => base.ExecuteGetAsync(queryString);
    }
}