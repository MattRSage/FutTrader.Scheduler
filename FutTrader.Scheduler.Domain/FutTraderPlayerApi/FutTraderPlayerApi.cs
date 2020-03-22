using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FutTrader.Domain.FutApi.Models;

namespace FutTrader.Domain.FutTraderPlayerApi
{
    public class FutTraderPlayerApi : IFutTraderPlayerApi
    {
        private readonly HttpClient _httpClient;
        private readonly FutTraderPlayerApiSettings _settings;

        public FutTraderPlayerApi(HttpClient httpClient, FutTraderPlayerApiSettings settings)
        {
            _httpClient = httpClient;
            _settings = settings;
        }
        
        public async Task<FUTPlayerItem> PutAsync(FUTPlayerItem player)
        {
            var url = _settings.Url + "player/" + player.FutPlayerItemId;
            var payload = JsonSerializer.Serialize(player);
            var content = new StringContent(payload, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(new Uri(url), content);

            var resultBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<FUTPlayerItem>(resultBody);
        }
    }
}