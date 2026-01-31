using MyMAUIApp.Models;
using MyMAUIApp.ViewModel;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Json;

namespace MyMAUIApp.Services
{

    public class APIService
    {
        private HttpClient _httpClient;
        public static string BaseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:8099" : "http://localhost:8099";
        public string StatusMessage { get; private set; } = "";


        public APIService()
        {
            _httpClient = new() { BaseAddress = new Uri(GetBaseAddress()) }; //BaseAddress
        }

        // Debug and release get api address 
        private static string GetBaseAddress()
        {
            #if DEBUG
                 return DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:8099" : "http://localhost:8099";
            #elif RELEASE
                // Publish address here
                return "https://carlistApi.com";
            #endif
        }

        public async Task<List<Car>> GetCars()
        {
            try
            {
                await SetauthToken();
                var response = await _httpClient.GetStringAsync("/cars");
                return JsonConvert.DeserializeObject<List<Car>>(response);

            }
            catch (Exception)
            {
                StatusMessage = "Failed to retrieve data";
            }
            return new List<Car>();
        }

        public async Task<Car> GetCar(int Id)
        {
            try
            {
                var response = await _httpClient.GetStringAsync("/cars/" + Id);
                return JsonConvert.DeserializeObject<Car>(response);

            }
            catch (Exception)
            {
                StatusMessage = "Failed to retrieve data";
            }
            return new Car();
        }

        public async Task AddCar(Car car)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/cars/", car);
                response.EnsureSuccessStatusCode();

                StatusMessage = "Intser Successfully";

            }
            catch (Exception)
            {
                StatusMessage = "Failed to add data";
            }
        }
        public async Task UpdateCar(int CarId, Car car)
        {

            try
            {
                var response = await _httpClient.PutAsJsonAsync("/cars/" + CarId, car);
                Debug.WriteLine("Response " + response);
                response.EnsureSuccessStatusCode();

                StatusMessage = "Update Successfully";

            }
            catch (Exception)
            {
                StatusMessage = "Failed to update data";
            }

        }
        public async Task DeleteCar(int Id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync("/cars/" + Id);
                response.EnsureSuccessStatusCode();

                StatusMessage = "Delete Successfully";

            }
            catch (Exception)
            {
                StatusMessage = "Failed to delete data";
            }
        }

        public async Task<AuthResponseModel?> Login(LoginModel loginModel )
        {
            try
            {
                var json = JsonConvert.SerializeObject(loginModel);
                Debug.WriteLine("Request : "+json);

                var reponse = await _httpClient.PostAsJsonAsync("/login", loginModel);
                Debug.WriteLine("Response " + reponse);
                reponse.EnsureSuccessStatusCode();
                StatusMessage = "Login Successful";
                                
                var content = await reponse.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<AuthResponseModel>(content);
               
                return result ?? default;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Messge :  " + e.Message);
                StatusMessage = "Login is failed..";
                return default;
            }
        }

        public async Task SetauthToken()
        {
            var token = await SecureStorage.GetAsync("Token");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }
    }
}
