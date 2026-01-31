using MyMAUIApp.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMAUIApp.ViewModel
{
    public partial class LogoutViewModel:BaseViewModel
    {
        public LogoutViewModel()
        {
            using var _ = Logout();
        }

        private async Task Logout()
        {
            SecureStorage.Remove("Token");
            App.CurrentUser = null;
            await Shell.Current.GoToAsync($"{nameof(LogoutPage)}");
        }
    }
}
