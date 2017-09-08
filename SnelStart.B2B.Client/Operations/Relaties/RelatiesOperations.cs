using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    internal class RelatiesOperations : CrudOperationsBase<RelatieModel>, IRelatiesOperations
    {
        public RelatiesOperations(ClientState clientState) : base(clientState, RelatieModel.ResourceName)
        {
        }

        public Task<Response<RelatieModel[]>> GetAllAsync() => base.ExecuteGetAllAsync();
        public Task<Response<RelatieModel[]>> GetAsync(string queryString) => base.ExecuteGetAsync(queryString);
    }
}