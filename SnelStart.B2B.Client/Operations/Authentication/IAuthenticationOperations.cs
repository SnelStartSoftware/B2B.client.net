using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    public interface IAuthenticationOperations
    {
        Task<LoginResponse> LoginAsync(string username, string password);
    }
}