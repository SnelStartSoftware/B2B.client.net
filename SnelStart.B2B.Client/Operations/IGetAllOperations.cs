using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    public interface IGetAllOperations<T>
    {
        Task<Response<T[]>> GetAllAsync();
    }
}