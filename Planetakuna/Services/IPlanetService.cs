using Planetakuna.Models;

namespace Planetakuna.Services
{
    public interface IPlanetService
    {
        Task<List<Planet>> GetPlanetsAsync(bool force);

    }
}
