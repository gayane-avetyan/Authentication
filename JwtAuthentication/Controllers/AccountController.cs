using JwtAuthentication.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IJwtTokenManager _jwtTokenManager;
        public AccountController(IJwtTokenManager jwtTokenManager)
        {
            _jwtTokenManager = jwtTokenManager;
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public IActionResult Login(string userName, string password)
        {
            var token = _jwtTokenManager.Authenticate(userName, password);

            if (string.IsNullOrEmpty(token))
                return Unauthorized();

            return Ok($"authenticated with token: {token}");
        }
    }
}
