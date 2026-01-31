using MyMAUIApp.ViewModel;

namespace MyMAUIApp.View
{
    public partial class LogoutPage : ContentPage
    {
        public LogoutPage(LogoutViewModel viewModel)
        {
            Content = new VerticalStackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Logging Out",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    }
                }
            };
            BindingContext = viewModel;
        }
    }
}
