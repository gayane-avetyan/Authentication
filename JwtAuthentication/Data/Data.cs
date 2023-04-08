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

        public static List<User> Users = new List<User>
        {
            new User{ UserName = "username", Password = "password", Role = "user"},
            new User{ UserName = "admin", Password = "admin", Role = "admin"}
        };
    }
}
