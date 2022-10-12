using SaitynoLab.Server.Dto;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<User> RegisterUser(UserAuthDto request);
        Task<string> LoginUser(UserAuthDto request);
    }
}
