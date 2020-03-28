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
        public async Task Run([TimerTrigger("0 0 18 * * *", RunOnStartup = true)] TimerInfo myTimer, ILogger logger)
        {
            try
            {
                var initialPageInfo = await _futApi.GetPlayerData(1);

                for (int i = 0; i < 1; i++)
                {
                    var pageData = await _futApi.GetPlayerData(i + 1);

                    foreach (var playerCard in pageData.Items)
                    {
                        await _futTraderPlayerApi.CreateAsync(playerCard);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError("GetPlayerData Failed", ex);
                throw;
            }
        }
    }
}