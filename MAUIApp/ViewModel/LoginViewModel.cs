using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyMAUIApp.Models;
using MyMAUIApp.Services;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace MyMAUIApp.ViewModel
{
    public partial class LoginViewModel : BaseViewModel
    {
        private readonly APIService apiService;
        NetworkAccess accessType = Connectivity.Current.NetworkAccess;
        string message = string.Empty;



        [ObservableProperty]
        string username;

        [ObservableProperty]
        string password;

        public LoginViewModel(APIService apiService)
        {
            this.apiService = apiService;
        }

        [RelayCommand]
        async Task Login()
        {
            // Simple validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayLoginError("Login Attempt Result", "Invalid Username and Password.");
            }
            else
            {

                var loginModel = new LoginModel(username, password);
                Console.Write($"Login Data = {loginModel.Username}");
                var resposnse = await apiService.Login(loginModel);

                // display welcome message
                await DisplayLoginError("Invalid Attempt", apiService.StatusMessage);

                if (resposnse != null)
                {
                    if (!string.IsNullOrEmpty(resposnse.Token))
                    {
                        // Store token in secure storage
                        await SecureStorage.SetAsync("Token", resposnse.Token);
                                                
                        // build a manu on the fly... based on the user role
                        var jsonToken = new JwtSecurityTokenHandler().ReadJwtToken(resposnse.Token) as JwtSecurityToken;
                        var role = jsonToken.Claims.FirstOrDefault(q => q.Type.Equals(ClaimTypes.Role))?.Value;
                        App.CurrentUser = new UserInfo
                        {
                            Username = Username,
                            Role = role
                        };

                        if(Preferences.ContainsKey(nameof(UserInfo)))
                            Preferences.Remove(nameof(UserInfo));


                        // Navigate to app's smain page
                        await Shell.Current.GoToAsync($"{nameof(MainPage)}");

                    }
                }
                else
                {
                    await DisplayLoginError("Invalid Attempt", "Invalid Login Attempt\n response is null");
                } 
            }
        }

        private async Task DisplayLoginError(string title, string message)
        {
            await Shell.Current.DisplayAlertAsync(title, message, "OK");
            Password = String.Empty;
        }
    }
}
