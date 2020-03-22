using System;
using System.Threading.Tasks;
using FutTrader.Domain.FutApi;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FutTrader.Scheduler.Functions.Triggers
{
    public class GetPlayerDataTrigger
    {
        private readonly IFutApi _futApi;

        public GetPlayerDataTrigger(IFutApi futApi)
        {
            _futApi = futApi;
        }
        
        [FunctionName("GetPlayerData")]
        public async Task Run([TimerTrigger("0 */1 * * * *")] TimerInfo myTimer, ILogger logger)
        {
            try
            {
                var playerData = await _futApi.GetPlayerData();
            }
            catch (Exception ex)
            {
                logger.LogError("GetPlayerData Failed", ex);
                throw;
            }
        }
    }
}