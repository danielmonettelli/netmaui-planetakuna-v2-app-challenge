using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace Planetakuna;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("customfonticons.ttf", "CustomFontIcons");
            fonts.AddFont("Kanit-Light.ttf", "Kanit#300");
        }).UseMauiCommunityToolkit();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}