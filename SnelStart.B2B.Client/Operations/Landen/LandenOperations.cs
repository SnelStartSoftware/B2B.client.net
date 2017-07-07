using System;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    internal class LandenOperations : OperationsBase<LandModel>, ILandenOperations
    {
        public LandenOperations(ClientState clientState)
            : base(clientState, "landen")
        {
        }

        public Task<Response<LandModel[]>> GetAllAsync() => base.ExecuteGetAllAsync();
        public Task<Response<LandModel>> GetByIdAsync(Guid id) => base.ExecuteGetByIdAsync(id);
    }
}