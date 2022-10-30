using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SaitynoLab.Shared.Dto;
using SaitynoLab.Server.Services.AuthService;
using SaitynoLab.Server.Services.UsersService;
using SaitynoLab.Shared;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace SaitynoLab.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(UserAuthDto request)
        {
            User response = await _authService.RegisterUser(request);
            if (response != null)
            {
                return Ok(new { Username = response.Username, message = "Successfully registered" });
            }
            else return NotFound(new { message = "Username already exists" });
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserAuthDto request)
        {
            string token = await _authService.LoginUser(request);
            if (token != null)
            {
                //return Ok(new { token = token });
                return Ok(token);
            }
            else return NotFound(new { message = "Wrong user or password" });
        }




        //pasitikrinimui ar veikia
        [HttpGet("userIsRegisteredUserMsg")]
        [Authorize(Roles = "RegisteredUser")]
        public ActionResult<string> GetMessageRegisteredUser()
        {
            //var userName = _userService.GetMyName();
            return Ok("Registered users can read this");
        }
        [HttpGet("userIsAdminMsg")]
        [Authorize(Roles = "Admin")]
        public ActionResult<string> GetMessageAdmin()
        {
            return Ok("Admins can read this");
        }
    }
}
