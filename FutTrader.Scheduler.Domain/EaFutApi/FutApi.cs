using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FutTrader.Domain.EaFutApi.Models;

namespace FutTrader.Domain.EaFutApi
{
    public class FutApi : IFutApi
    {
        private readonly HttpClient _httpClient;

        public FutApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<FUTPlayerItemResponse> GetPlayerData()
        {
            return await GetAsync<FUTPlayerItemResponse>();
        }
        
        private async Task<T> GetAsync<T>()
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri($"https://www.easports.com/fifa/ultimate-team/api/fut/item"),
                Method = HttpMethod.Get
            };
            
            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            var body = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(body);
        }
    }
}