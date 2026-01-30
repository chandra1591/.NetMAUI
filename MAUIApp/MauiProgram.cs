
using Microsoft.Extensions.Logging;
using MyMAUIApp.Services;
using MyMAUIApp.View;
using MyMAUIApp.ViewModel;
using SQLitePCL;

namespace MyMAUIApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            Batteries_V2.Init();

            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

            // ✅ Database Path
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "car.db3");
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);

            // ✅ Register CarService CORRECTLY
            builder.Services.AddSingleton<CarService>(sp => new CarService(dbPath));

            // ✅ Web API Service
            builder.Services.AddTransient<APIService>();

            // ViewModels
            builder.Services.AddSingleton<CarListViewModel>();
            builder.Services.AddSingleton<CarDetailsViewModel>();
            builder.Services.AddSingleton<LoadingViewModel>();
            builder.Services.AddSingleton<LoginViewModel>();

            // Pages
            builder.Services.AddSingleton<LoadingPage>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<CarDetailsPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
