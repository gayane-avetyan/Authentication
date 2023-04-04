namespace JwtAuthentication.Interfaces
{
    public interface IJwtTokenManager
    {
        string Authenticate(string userName, string password);
    }
}
