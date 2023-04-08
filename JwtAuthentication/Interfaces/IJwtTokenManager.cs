using JwtAuthentication.Models;

namespace JwtAuthentication.Interfaces
{
    public interface IJwtTokenManager
    {
        string Authenticate(User user);
    }
}
