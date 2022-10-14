using Microsoft.EntityFrameworkCore;
using SaitynoLab.Server.Data;
using SaitynoLab.Server.Dto;
using SaitynoLab.Shared;
using System.Security.Claims;

namespace SaitynoLab.Server.Services.UsersService
{
    public class UsersService : IUsersService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly DataContext _context;

        public UsersService(IHttpContextAccessor httpContextAccessor, DataContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        public async Task<User> AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteUser(int id)
        {
            User dbUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (dbUser == null)
            {
                return null;
            }
            _context.Users.Remove(dbUser);
            await _context.SaveChangesAsync();
            return dbUser;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public string GetMyName()
        {
            var result = string.Empty;
            if (_httpContextAccessor.HttpContext != null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;
        }

        public async Task<User> GetUser(int id)
        {
            User? user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            return user; ;
        }

        public async Task<User> UpdateUser(int id, UserUpdateDto userUpdateDto)
        {
            var dbUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (dbUser == null)
            {
                return null;
            }
            dbUser.Username = userUpdateDto.Username;
            dbUser.Role = userUpdateDto.Role;
            await _context.SaveChangesAsync();
            return dbUser;
        }
    }
}
