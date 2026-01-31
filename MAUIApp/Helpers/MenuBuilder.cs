using Microsoft.Maui.Controls;
using MyMAUIApp.Controls;
using MyMAUIApp.View;


namespace MyMAUIApp.Helpers
{
    public static class MenuBuilder
    {
        public static void BuildManu()
        {
            Shell.Current.Items.Clear();

            Shell.Current.FlyoutHeader = new FlyOutHeader();

            var role = App.CurrentUser!.Role;

            if (role.Equals("Administrator"))
            {
                var floyOutItem = new FlyoutItem()
                {
                    Title = "Admin Car Management",
                    Route = nameof(MainPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items = { 
                        new ShellContent
                        {
                            Title = "Admin Page 1",
                            Icon = "home.png",
                            ContentTemplate = new DataTemplate(typeof(MainPage))
                        }
                    }
                }; 

               if(!Shell.Current.Items.Contains(floyOutItem))
               {
                    Shell.Current.Items.Add(floyOutItem);
               }   
            }

            if (role.Equals("User"))
            {
                var floyOutUserItem = new FlyoutItem()
                {
                    Title = "User Car Management",
                    Route = nameof(MainPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items = {
                        new ShellContent
                        {
                            Title = "User Page 1",
                            Icon = "home.png",
                            ContentTemplate = new DataTemplate(typeof(MainPage))
                        },
                    }
                };

                if (!Shell.Current.Items.Contains(floyOutUserItem))
                {
                    Shell.Current.Items.Add(floyOutUserItem);
                }
            }
            var logoutFlyItem = new FlyoutItem()
            {
                Title = "Logout",
                Route = nameof(LoginPage),
                FlyoutDisplayOptions = FlyoutDisplayOptions.AsSingleItem,
                Items =
                {
                    new ShellContent
                    {
                        Title = "Logout",
                        Icon = "logout.png",
                        ContentTemplate = new DataTemplate(typeof(LoginPage))
                    }
                }
            };
            if (!Shell.Current.Items.Contains(logoutFlyItem))
            {
                Shell.Current.Items.Add(logoutFlyItem);
            }
            /*Shell.Current.Items.Add(new MenuItem
            {
                Text = "Logout",
                IconImageSource = "logout.png",
                Command = new Command(async () =>
                {
                    SecureStorage.Remove("Token");
                    App.CurrentUser = null;
                    await Shell.Current.GoToAsync($"{nameof(LoginPage)}");
                })
            });*/
        }
    }
}
