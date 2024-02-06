using Microsoft.Extensions.Logging;
using Neptune.Templates;
using Neptune.Views;
using The49.Maui.BottomSheet;
using UraniumUI;

namespace Neptune
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseUraniumUI()
                .UseUraniumUIMaterial()
                .UseBottomSheet()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Raleway-Light.ttf", "RalewayLight");
                    fonts.AddFont("Raleway-Medium.ttf", "RalewayMedium");
                    fonts.AddFont("Raleway-Regular.ttf", "RalewayRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<OptionSheet>();
            builder.Services.AddTransient<MainPage>();
            return builder.Build();
        }
    }
}
