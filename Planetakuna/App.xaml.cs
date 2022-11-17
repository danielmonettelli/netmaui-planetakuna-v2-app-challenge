using Planetakuna.Models;
using Planetakuna.Services;

namespace Planetakuna;

public partial class App : Application
{
    public static IPlanetService PlanetService { get; } = new PlanetService(new PlanetRepository());

    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new PlanetsLookoutPage());
    }
}
