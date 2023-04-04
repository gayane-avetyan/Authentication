using JwtAuthentication.Models;

namespace JwtAuthentication.Data
{
    public static class Data
    {
        public static string[] Summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm",
                "Balmy", "Hot", "Sweltering", "Scorching"
            };

        public static User[] Users = new[]
        {
            new User{ UserName = "username", Password = "password" }
        };
    }
}
