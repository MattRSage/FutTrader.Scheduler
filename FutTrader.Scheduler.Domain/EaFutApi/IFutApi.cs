using System.Threading.Tasks;
using FutTrader.Domain.EaFutApi.Models;

namespace FutTrader.Domain.EaFutApi
{
    public interface IFutApi
    {
        Task<FUTPlayerItemResponse> GetPlayerData();
    }
}