using System.Threading.Tasks;
using FutTrader.Domain.FutApi.Models;

namespace FutTrader.Domain.FutTraderPlayerApi
{
    public interface IFutTraderPlayerApi
    {
        Task<FUTPlayerItem> CreateAsync(FUTPlayerItem player);

        Task<FUTPlayerItem> PutAsync(FUTPlayerItem player);
    }
}