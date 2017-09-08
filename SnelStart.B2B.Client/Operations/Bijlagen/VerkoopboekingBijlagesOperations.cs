using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    internal class VerkoopboekingBijlagesOperations : CrudOperationsBase<VerkoopBoekingBijlageContentModel>,
        IVerkoopboekingBijlagesOperations
    {
        public VerkoopboekingBijlagesOperations(ClientState clientState) : base(clientState,
            VerkoopBoekingBijlageContentModel.ResourceName)
        {
        }   

        public Task<Response<VerkoopBoekingBijlageContentModel[]>> GetAllAsync() => base.ExecuteGetAllAsync();
        public Task<Response<VerkoopBoekingBijlageContentModel[]>> GetAsync(string queryString) => base.ExecuteGetAsync(queryString);
    }
}