using Planetakuna.Utility;

namespace Planetakuna;

public partial class PlanetsLookoutPage : ContentPage
{
    public PlanetsLookoutPage()
    {
        InitializeComponent();

        BindingContext = ViewModelLocator.PlanetsLookoutViewModel;
    }

}