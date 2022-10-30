using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaitynoLab.Shared.Dto;
using SaitynoLab.Server.Services.UsersService;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            List<User> response = await _usersService.GetAllUsers();
            if (response.Count > 0)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "No users found" });

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            User response = await _usersService.GetUser(id);
            if (response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "User not found" });
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            User response = await _usersService.AddUser(user);
            if (response != null)
            {
                return Created($"/api/users/{response.Id}", response);
            }
            else return NotFound(new { message = "User was not created" });
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(int id, UserUpdateDto userUpdateDto)
        {
            User response = await _usersService.UpdateUser(id, userUpdateDto);
            if (response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "User not found" });

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            User response = await _usersService.DeleteUser(id);
            if (response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "User not found" });
        }
    }
}