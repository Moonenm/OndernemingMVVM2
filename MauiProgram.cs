
using Microsoft.Extensions.Logging;


namespace OndernemingMVVM2
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<VoorbeeldViewModel>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<WerknemerDetailsViewModel>();
            builder.Services.AddSingleton<ApiViewModel>();
            builder.Services.AddSingleton<DetailMoviePageViewModel>();

            builder.Services.AddSingleton<WerknemerRepository>();

            builder.Services.AddSingleton<Voorbeeld>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<WerknemerDetails>();
            builder.Services.AddSingleton<IpAdresPage>();
            builder.Services.AddSingleton<MoviePage>();
            builder.Services.AddSingleton<DetailMoviePage>();

            return builder.Build();
        }
    }
}
