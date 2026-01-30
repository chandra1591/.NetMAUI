using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyMAUIApp.Models;
using MyMAUIApp.Services;
using System.Web;


namespace MyMAUIApp.ViewModel;

[QueryProperty(nameof(Id), nameof(Id))]
public partial class CarDetailsViewModel : BaseViewModel, IQueryAttributable
{
    NetworkAccess accessType = Connectivity.Current.NetworkAccess;
    private readonly APIService apiService;

    public CarDetailsViewModel(APIService apiService)
    {
        this.apiService = apiService;
    }

    [ObservableProperty]
    Car car;

    [ObservableProperty]
    int id;


    void IQueryAttributable.ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Id = Convert.ToInt32(HttpUtility.UrlDecode(query["Id"].ToString()));
    }

    [RelayCommand]
    public async Task GetCarData()
    {
        if (accessType == NetworkAccess.Internet)
        {
            Car = await apiService.GetCar(Id);
        }
        else
        {
            Car = App.CarService.GetCar(Id);
        }
    }
}