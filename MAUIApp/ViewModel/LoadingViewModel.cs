using MyMAUIApp.View;
using System.IdentityModel.Tokens.Jwt;

namespace MyMAUIApp.ViewModel
{
    public class LoadingViewModel : BaseViewModel
    {
        public LoadingViewModel()
        {
            CheckUserLoginDetails();
        }

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
                var jsonToken = new JwtSecurityTokenHandler().ReadToken(token) as JwtSecurityToken;
                if (jsonToken == null || jsonToken.ValidTo < DateTime.UtcNow)
                {
                    SecureStorage.Remove("Token");
                    await GoTOoLoginPage();
                }
                else
                {
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
