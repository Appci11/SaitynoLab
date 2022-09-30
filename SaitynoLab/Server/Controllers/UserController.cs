using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaitynoLab.Server.Dto;
using SaitynoLab.Server.Services.UserService;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            List<User> response = await _userService.GetAllUsers();
            if (response.Count > 0)
            {
                return Ok(response);
            }
            else return NotFound();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            User response = await _userService.GetUser(id);
            if (response == null)
            {
                return NotFound();
            }
            else return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            User response = await _userService.AddUser(user);
            return Ok(response);
        }
        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(UserUpdateDto userUpdateDto)
        {
            return Ok(await _userService.UpdateUser(userUpdateDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            return Ok(await _userService.DeleteUser(id));
        }
    }
}