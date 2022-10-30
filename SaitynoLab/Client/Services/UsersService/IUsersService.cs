namespace SaitynoLab.Client.Services.UsersService
{
    public interface IUsersService
    {
        List<User> Users { get; set; }

        Task GetUsers();
        Task<User> GetSingleUser(int id);
        Task CreateUser (User user);
        Task UpdateUser (User user);
        Task DeleteUser (int id);
    }
}
