using SaitynoLab.Shared.Dto;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Services.UsersService
{
    public interface IUsersService
    {
        string GetMyName();
        Task<User> AddUser(User user);
        Task<List<User>> GetAllUsers();
        Task<User> GetUser(int id);
        Task<User> UpdateUser(int id, UserUpdateDto userUpdateDto);
        Task<User> DeleteUser(int id);
    }
}
