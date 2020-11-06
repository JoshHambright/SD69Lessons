using _10_IntroToAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPIs
{
    public class TacoService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string baseUrl = "http://taco-randomizer.herokuapp.com/random/";

        public async Task<TacoRecipe> GetTacoRecipeAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(baseUrl);
            if (response.IsSuccessStatusCode)
            {
                TacoRecipe tacoRecipe = await response.Content.ReadAsAsync<TacoRecipe>();
                return tacoRecipe;
            }
            return null;
        }
    }
}
