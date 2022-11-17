using CommunityToolkit.Mvvm.ComponentModel;
using Planetakuna.Models;
using Planetakuna.Services;

namespace Planetakuna.ViewModels
{
    public partial class PlanetsLookoutViewModel : ObservableObject
    {
        private readonly IPlanetService _planetService;

        [ObservableProperty]
        private List<Planet> planets;

        public PlanetsLookoutViewModel(IPlanetService planetService)
        {
            _planetService = planetService;

            OnGetPlanets();
        }

        private async void OnGetPlanets()
        {
            Planets = await _planetService.GetPlanetsAsync(false);
        }

    }
}
