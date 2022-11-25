using System.Text.Json;

namespace Planetakuna.Models
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly HttpClient _httpClient;

        static readonly string BaseAddress = "https://apimocha.com/planetakuna";
        static readonly string UrlPlanets = $"{BaseAddress}/planets";

        public PlanetRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Planet>> GetPlanetsAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(UrlPlanets);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Planet>>(content);
            }
            return null;
        }

    }
}
