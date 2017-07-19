using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    public interface IQueryOperations<T>
    {
        Task<Response<T[]>> GetAsync(string queryString);
    }
}