using CommunityToolkit.Mvvm.ComponentModel;

namespace MyMAUIApp.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotLoading))]
        bool isLoading;


        public bool IsNotLoading => !isLoading;
    }
}
