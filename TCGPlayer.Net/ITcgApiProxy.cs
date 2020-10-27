using System.Threading.Tasks;
using TCGPlayer.Net.Models;

namespace TCGPlayer.Net
{
    public interface ITcgApiProxy
    {
        Task<TcgApiResult<string>> Get(string action, IQueryStringParams parameters);
        Task<TcgApiResult<string>> Post(string action, IJsonQueryParams parameters);
        Task<TcgApiResult<string>> Put(string action, IJsonQueryParams parameters);
    }
}
