using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyMAUIApp.Models;
using MyMAUIApp.Services;
using MyMAUIApp.View;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyMAUIApp.ViewModel
{
    public partial class CarListViewModel : BaseViewModel
    {
        //private readonly CarService carService;
        private readonly APIService apiService;
        const string editButtenText = "Update Car";
        const string createButtonText = "Add Car";
        NetworkAccess accessType = Connectivity.Current.NetworkAccess;
        string message = string.Empty;
        public ObservableCollection<Car> Cars { get; private set; } = new();

        /* public CarListViewModel(CarService carService)
         {
             Title = "Car List";
             this.carService = carService;
         }*/

        //public CarListViewModel()
        //{
        //    Title = "Car List";
        //    AddEditButtonText = createButtonText;
        //    GetCarlist().Wait();
        //}

        public CarListViewModel(APIService apiService)
        {
            Title = "Car List";
            AddEditButtonText = createButtonText;
            this.apiService = apiService;
        }

        [ObservableProperty]
        bool isRefreshing;
        [ObservableProperty]
        string make;
        [ObservableProperty]
        string model;
        [ObservableProperty]
        string vin;
        [ObservableProperty]
        string addEditButtonText;
        [ObservableProperty]
        int carId;


        [RelayCommand]
        async Task SaveCar()
        {
            if (string.IsNullOrEmpty(Make) || string.IsNullOrEmpty(Model) || string.IsNullOrEmpty(Vin))
            {
                await CarListViewModel.ShowAlert("Invali Data", "Please insert valid data.");
                return;
            }

            var car = new Car
            {

                Make = Make,
                Model = Model,
                Vin = Vin
            };

            if (CarId != 0)
            {
                car.Id = CarId;
                Console.WriteLine("Insert Cat  id " + CarId);
                Debug.WriteLine("Insert Cat  id " + car.Id);

                if (accessType == NetworkAccess.Internet)
                {
                    await apiService.UpdateCar(CarId, car);
                    message = apiService.StatusMessage;
                }
                else
                {
                    App.CarService!.UpdateCar(car);
                    message = App.CarService.StatusMessage;
                }

            }
            else
            {
                if (accessType == NetworkAccess.Internet)
                {
                    await apiService.AddCar(car);
                    message = apiService.StatusMessage;
                }
                else
                {
                    App.CarService!.AddCar(car);
                    message = App.CarService.StatusMessage;
                }

            }

            await CarListViewModel.ShowAlert("Info", message);

            await GetCarlist();
            await ClearForm();
        }

        [RelayCommand]
        async Task DeleteCar(int Id)
        {
            if (Id == 0)
            {
                await CarListViewModel.ShowAlert("Invalid Record", "Please try again");
                return;
            }

            if (accessType == NetworkAccess.Internet)
            {
                await apiService.DeleteCar(Id);
                message = apiService.StatusMessage;
                await CarListViewModel.ShowAlert("Deletion Info", message);
                await GetCarlist();
            }
            else
            {
                var result = App.CarService!.DeleteCar(Id);
                if (result == 0)
                {
                    await CarListViewModel.ShowAlert("Invalid Record", "Please insert valid data.");
                }
                else
                {
                    await CarListViewModel.ShowAlert("Deletion Successfully", "Record remove successfully");
                    await GetCarlist();
                }
            }
        }

        [RelayCommand]
        async Task UpdateMyCar()
        {

            if (string.IsNullOrEmpty(Make) || string.IsNullOrEmpty(Model) || string.IsNullOrEmpty(Vin))
            {
                await CarListViewModel.ShowAlert("Invalid Data", "Please Update valid data.");
                return;
            }

            var car = new Car
            {
                Id = CarId,
                Make = Make,
                Model = Model,
                Vin = Vin
            };

            if (accessType == NetworkAccess.Internet)
            {
                await apiService.UpdateCar(CarId, car);
                message = apiService.StatusMessage;
            }
            else
            {
                App.CarService!.UpdateCar(car);
                message = App.CarService.StatusMessage;
            }

            await CarListViewModel.ShowAlert("Info", message);
            await GetCarlist();
        }

        [RelayCommand]
        async Task GetCarlist()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (Cars.Any()) Cars.Clear();
                var cars = new List<Car>();
                if (accessType == NetworkAccess.Internet)
                {
                    cars = await apiService.GetCars();
                }
                else
                {
                    cars = App.CarService!.GetCars();
                }
                //var cars = carService.GetCars();
                foreach (var car in cars) Cars.Add(car);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get cars : {ex.Message}");
                await CarListViewModel.ShowAlert("Error", "Failed to retive list of cars.");
            }
            finally
            {
                IsLoading = false;
                IsRefreshing = false;
            }
        }


        [RelayCommand]
        async Task GetCarDetails(int Id)
        {
            if (Id == 0)
            {
                await CarListViewModel.ShowAlert("Invalid Record", "Please try again.");
                return;
            }

            Console.WriteLine($"user is {Id}");

            await Shell.Current.GoToAsync($"{nameof(CarDetailsPage)}?Id={Id}", true);



            //if (car == null) return;

            //await Shell.Current.GoToAsync(nameof(CarDetailsPage), true, new Dictionary<string, object>
            //{
            //    { nameof(Car), car }
            //});
        }


        [RelayCommand]
        async Task AddEditMode(int id)
        {
            AddEditButtonText = editButtenText;
            CarId = id;

            var car = await apiService.GetCar(id);
            Make = car.Make;
            Model = car.Model;
            Vin = car.Vin;

            //if (accessType == NetworkAccess.Internet)
            //{
            //    var car = await apiService.GetCar(id);
            //    Make = car.Make;
            //    Model = car.Model;
            //    Vin = car.Vin;
            //}
            //else {
            //    var car = App.CarService.GetCar(id);
            //    Make = car.Make;
            //    Model = car.Model;
            //    Vin = car.Vin;
            //}

            Console.WriteLine($"Car Id {CarId}");

        }

        [RelayCommand]
        async Task ClearForm()
        {
            AddEditButtonText = createButtonText;
            Make = string.Empty;
            Model = string.Empty;
            Vin = string.Empty;
            CarId = 0;
        }

        private static async Task ShowAlert(string title, string mesage)
        {
            await Shell.Current.DisplayAlertAsync(title, mesage, "Ok");
        }

    }

}
