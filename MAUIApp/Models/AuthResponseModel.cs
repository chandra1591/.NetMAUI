using System;
using System.Collections.Generic;
using System.Text;

namespace MyMAUIApp.Models
{
    public class AuthResponseModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
    }

    public class LoginModel
    {
        public LoginModel(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserInfo
    {
        public string Username { get; set; }
        public string Role { get; set; }
    }
}
