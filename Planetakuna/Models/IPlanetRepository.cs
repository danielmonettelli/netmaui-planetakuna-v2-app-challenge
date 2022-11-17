namespace Planetakuna.Models
{
    public interface IPlanetRepository
    {
        Task<List<Planet>> GetPlanetsAsync();
    }
}
