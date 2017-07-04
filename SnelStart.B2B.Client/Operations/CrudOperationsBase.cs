using System;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    internal class CrudOperationsBase<T> : OperationsBase<T>, ICrudOperations<T> where T : IIdentifierModel
    {
        public CrudOperationsBase(ClientState clientState, string resourceName) : base(clientState, resourceName)
        {
        }

        public Task<Response<T>> CreateAsync(T dto) => base.ExecutePostAsync(dto);
        public Task<Response<T>> UpdateAsync(T dto) => base.ExecutePutAsync(dto);
        public Task<Response<T>> GetByIdAsync(Guid id) => base.ExecuteGetByIdAsync(id);
        public Task<Response> DeleteAsync(Guid id) => base.ExecuteDeleteAsync(id);
        public Task<Response> DeleteAsync(T dto) => base.ExecuteDeleteAsync(dto.Id);

    }
}