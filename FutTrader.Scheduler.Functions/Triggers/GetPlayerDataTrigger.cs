using System;
using System.Linq;
using System.Threading.Tasks;
using FutTrader.Domain.FutApi;
using FutTrader.Domain.FutTraderPlayerApi;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FutTrader.Scheduler.Functions.Triggers
{
    public class GetPlayerDataTrigger
    {
        private readonly IFutApi _futApi;
        private readonly IFutTraderPlayerApi _futTraderPlayerApi;

        public GetPlayerDataTrigger(IFutApi futApi, IFutTraderPlayerApi futTraderPlayerApi)
        {
            _futApi = futApi;
            _futTraderPlayerApi = futTraderPlayerApi;
        }
        
        [FunctionName("GetPlayerData")]
        public async Task Run([TimerTrigger("0 */1 * * * *")] TimerInfo myTimer, ILogger logger)
        {
            try
            {
                var playerData = await _futApi.GetPlayerData();
                var firstPlayer = playerData.Items.First();

                await _futTraderPlayerApi.CreateAsync(firstPlayer);
            }
            catch (Exception ex)
            {
                logger.LogError("GetPlayerData Failed", ex);
                throw;
            }
        }
    }
}