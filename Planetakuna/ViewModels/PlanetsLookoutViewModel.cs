using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Planetakuna.Models;
using Planetakuna.Services;

namespace Planetakuna.ViewModels
{
    public partial class PlanetsLookoutViewModel : ObservableObject
    {
        private readonly IPlanetService _planetService;

        [ObservableProperty]
        private List<Planet> planets;

        [ObservableProperty]
        private List<Feature> myFeatures;

        [ObservableProperty]
        private Planet myPlanet;

        public PlanetsLookoutViewModel(IPlanetService planetService)
        {
            _planetService = planetService;

            OnGetPlanets();
        }

        private async void OnGetPlanets()
        {
            Planets = await _planetService.GetPlanetsAsync(false);
        }

        [RelayCommand]
        private void SelectedPlanet(Planet planet)
        {
            if (planet is not null)
            {
                MyPlanet = planet;

                MyFeatures = planet.Features;
            }
        }

    }
}
