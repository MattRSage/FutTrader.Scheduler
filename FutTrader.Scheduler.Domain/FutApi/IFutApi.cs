using System.Threading.Tasks;
using FutTrader.Domain.FutApi.Models;

namespace FutTrader.Domain.FutApi
{
    public interface IFutApi
    {
        Task<FUTPlayerItemResponse> GetPlayerData();
    }
}