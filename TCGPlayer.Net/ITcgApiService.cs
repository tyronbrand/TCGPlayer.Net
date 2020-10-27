using System.Threading.Tasks;

namespace TCGPlayer.Net
{
    public interface ITcgApiService
    {
        Task<TcgApiResult<TResult>> Execute<TParams, TResult>(ApiActionAttributes<TParams, TResult> apiAction, TParams @params);
    }
}
