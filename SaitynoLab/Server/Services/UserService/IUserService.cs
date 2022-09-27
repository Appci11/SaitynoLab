using SaitynoLab.Server.Dto;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Services.UserService
{
    public interface IUserService
    {
        string GetMyName();
        Task<User> AddUser(User user);
        Task<List<User>> GetAllUsers();
        Task<User> GetUser(int id);
        Task<User> UpdateUser(UserUpdateDto userUpdateDto);
        Task<User> DeleteUser(int id);
    }
}
