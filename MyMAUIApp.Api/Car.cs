namespace MyMAUIApp.Api
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; } = default!;
        public string Model { get; set; } = default!;
        public string Vin { get; set; } = default!;

    }


    public class ResetPasswordRequest
    {
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}