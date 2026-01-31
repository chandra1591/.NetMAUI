using MyMAUIApp.Helpers;
using MyMAUIApp.Models;
using MyMAUIApp.View;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json;

namespace MyMAUIApp.ViewModel
{
    public class LoadingViewModel : BaseViewModel
    {
        public LoadingViewModel() => CheckUserLoginDetails();

        private async Task CheckUserLoginDetails()
        {
            // Retrieve token from internal storage
            var token = await SecureStorage.GetAsync("Token");

            if (string.IsNullOrEmpty(token))
            {
                await GoTOoLoginPage();
            }

            // Evalutae token and  decide if valid

            else
            {
                // Token is valid, navigate to main page
                if (new JwtSecurityTokenHandler().ReadToken(token) is not JwtSecurityToken jsonToken || jsonToken.ValidTo < DateTime.UtcNow)
                {
                    SecureStorage.Remove("Token");
                    await GoTOoLoginPage();
                }
                else
                {
                    var data = jsonToken.Claims.ToList();
                    Console.WriteLine("Claims:" + JsonConvert.SerializeObject(data));

                    var role = jsonToken.Claims.FirstOrDefault(q => q.Type.Equals(ClaimTypes.Role))?.Value ?? string.Empty;
                    var email = jsonToken.Claims.FirstOrDefault(q => q.Type.Equals(ClaimTypes.Email))?.Value ?? string.Empty;
                    App.CurrentUser = new UserInfo
                    {
                        Username = email,
                        Role = role
                    };
                    MenuBuilder.BuildManu();
                    await GoToMainPage();
                }
            }
        }

        private async Task GoTOoLoginPage()
        {
            await Shell.Current.GoToAsync($"{nameof(LoginPage)}");
        }

        private async Task GoToMainPage()
        {
            await Shell.Current.GoToAsync($"{nameof(MainPage)}");
        }
    }
}
