using Microsoft.Extensions.Logging;

namespace Neptune
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
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

            return builder.Build();
        }
    }
}
