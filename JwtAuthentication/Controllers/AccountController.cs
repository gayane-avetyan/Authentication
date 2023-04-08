using JwtAuthentication.Dto;
using JwtAuthentication.Interfaces;
using JwtAuthentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

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
        public IActionResult Register([FromBody] Register request)
        {
            var user = new User
            {
                UserName = request.UserName,
                Password = request.Password,
                Role = request.Role
            };

            Data.Data.Users.Add(user);

            return Ok(user);
        }


        [AllowAnonymous]
        [HttpPost("[action]")]
        public IActionResult Login([FromBody] Login request)
        {
            var user = Data.Data.Users
                .Where(x => x.UserName == request.UserName)
                .FirstOrDefault();

            if (user == null)
                return BadRequest("Invalid user");

            var token = _jwtTokenManager.Authenticate(user);

            if (string.IsNullOrEmpty(token))
                return Unauthorized();

            return Ok($"bearer {token}");
        }
    }
}
