using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    internal class GrootboekenOperations : CrudOperationsBase<GrootboekModel>, IGrootboekenOperations
    {
        public GrootboekenOperations(ClientState clientState)
            : base(clientState, GrootboekModel.ResourceName)
        { }

        public Task<Response<GrootboekModel[]>> GetAllAsync() => GetAllAsync(CancellationToken.None);
        public Task<Response<GrootboekModel[]>> GetAllAsync(CancellationToken cancellationToken)
        {

            var result = ClientState.ExecuteGetAllAsync<GrootboekModel>(ResourceName, cancellationToken);
            return result.ContinueWith<Response<GrootboekModel[]>>((firstTaskResult) =>
            {
                if (firstTaskResult.Result.Result?.Count() == 500)
                {
                    var grootboeken = firstTaskResult.Result.Result;
                    bool hasNextPage = true;
                    var skip = 500;
                    while (hasNextPage)
                    {
                        var nextPageResult = GetAsync($"$skip={skip}&$top=500").GetAwaiter().GetResult();
                        if ((int)nextPageResult.HttpStatusCode >= 200 && (int)nextPageResult.HttpStatusCode <= 299)
                        {
                            hasNextPage = nextPageResult.Result.Count() == 500;
                            skip += nextPageResult.Result.Count();
                            grootboeken = grootboeken.Concat(nextPageResult.Result).ToArray();
                        }
                    }

                    return new Response<GrootboekModel[]>()
                    {
                        HttpStatusCode = firstTaskResult.Result.HttpStatusCode,
                        ResponseBody = firstTaskResult.Result.ResponseBody,
                        Result = grootboeken
                    };
                }
                else
                {
                    return firstTaskResult.Result;
                }
            });
        }
        public Task<Response<GrootboekModel[]>> GetAsync(string queryString) => GetAsync(queryString, CancellationToken.None);
        public Task<Response<GrootboekModel[]>> GetAsync(string queryString, CancellationToken cancellationToken) => ClientState.ExecuteGetAsync<GrootboekModel>(ResourceName, queryString, cancellationToken);
    }
}