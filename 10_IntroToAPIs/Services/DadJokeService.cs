using _10_IntroToAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPIs
{
    public class DadJokeService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string baseUrl = "https://icanhazdadjoke.com/";

        public async Task<DadJoke> GetDadJoke()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(baseUrl);
            _httpClient.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header


            if (response.IsSuccessStatusCode)
            {
                DadJoke dadjoke = await response.Content.ReadAsAsync<DadJoke>();
                return dadjoke;
            }
            return null;
        }
    }

}
