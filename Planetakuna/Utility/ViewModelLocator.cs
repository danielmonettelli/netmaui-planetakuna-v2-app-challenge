using Planetakuna.ViewModels;

namespace Planetakuna.Utility
{
    public static class ViewModelLocator
    {
        public static PlanetsLookoutViewModel PlanetsLookoutViewModel { get; set; } = new PlanetsLookoutViewModel(App.PlanetService);
    }
}
