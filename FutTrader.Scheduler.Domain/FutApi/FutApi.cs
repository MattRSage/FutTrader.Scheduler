﻿using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FutTrader.Domain.FutApi.Models;

namespace FutTrader.Domain.FutApi
{
    public class FutApi : IFutApi
    {
        private readonly HttpClient _httpClient;

        public FutApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<FUTPlayerItemResponse> GetPlayerData(int pageNumber)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri($"https://www.easports.com/fifa/ultimate-team/api/fut/item?page={pageNumber}"),
                Method = HttpMethod.Get
            };
            
            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            var body = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<FUTPlayerItemResponse>(body);
        }
    }
}