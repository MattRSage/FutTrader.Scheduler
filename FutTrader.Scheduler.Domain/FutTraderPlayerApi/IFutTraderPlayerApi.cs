using System.Threading.Tasks;
using FutTrader.Domain.FutApi.Models;

namespace FutTrader.Domain.FutTraderPlayerApi
{
    public interface IFutTraderPlayerApi
    {
        Task<FUTPlayerItemResponse> PutAsync(FUTPlayerItemResponse page);
    }
}