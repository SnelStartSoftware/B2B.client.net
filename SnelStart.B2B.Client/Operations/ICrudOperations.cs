using System;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    public interface ICrudOperations<T>
    {
        Task<Response<T>> CreateAsync(T dto);
        Task<Response<T>> UpdateAsync(T dto);
        Task<Response<T>> GetByIdAsync(Guid id);
        Task<Response> DeleteAsync(Guid id);
        Task<Response> DeleteAsync(T dto);
    }
}