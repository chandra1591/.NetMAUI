using MyMAUIApp.Models;
using MyMAUIApp.Services;

namespace MyMAUIApp
{
    public partial class App : Application
    {
        public static UserInfo? CurrentUser { get; set; }
        public static CarService? CarService { get; private set; }
        public App(CarService carService)
        {
            InitializeComponent();
            CarService = carService;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}