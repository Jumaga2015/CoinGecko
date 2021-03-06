using System.Threading.Tasks;
using CoinGecko.Entities.Response.Global;

namespace CoinGecko.Interfaces
{
    public interface IGlobalClient
    {
        /// <summary>
        /// Get cryptocurrency global data
        /// </summary>
        /// <returns></returns>
        Task<Global> GetGlobal();
    }
}