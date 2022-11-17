using Planetakuna.Models;

namespace Planetakuna.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository _planetRepository;

        public PlanetService(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        public async Task<List<Planet>> GetPlanetsAsync(bool force)
        {
            return await _planetRepository.GetPlanetsAsync();
        }

    }
}
