using MyMAUIApp.ViewModel;

namespace MyMAUIApp.View;

public partial class LoadingPage : ContentPage
{
    public LoadingPage(LoadingViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}