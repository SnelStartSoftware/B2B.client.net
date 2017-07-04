using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations.Kostenplaatsen
{
    public interface IKostenplaatsenOperations : ICrudOperations<KostenplaatsModel>
    {
        Task<Response<KostenplaatsModel[]>> GetAllAsync();
    }
}