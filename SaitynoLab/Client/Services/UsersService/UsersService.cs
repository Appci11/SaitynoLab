using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace SaitynoLab.Client.Services.UsersService
{
    public class UsersService : IUsersService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public UsersService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<User> Users {get; set;} = new List<User>();

        public async Task CreateUser(User user)
        {
            var result = await _http.PostAsJsonAsync("api/users", user);
            await GetUsers();
            _navigationManager.NavigateTo("users");
        }

        public async Task DeleteUser(int id)
        {
            var result = await _http.DeleteAsync($"api/users/{id}");
            await GetUsers();
            _navigationManager.NavigateTo("users");
        }

        public async Task<User> GetSingleUser(int id)
        {
            var result = await _http.GetFromJsonAsync<User>($"api/users/{id}");
            if (result != null)
            {
                return result;
            }
            throw new Exception("User not found");
        }

        public async Task GetUsers()
        {
            var result = await _http.GetFromJsonAsync<List<User>>("api/users");
            if(result != null)
            {
                Users = result;
            }
        }

        public async Task UpdateUser(User user)
        {
            var result = await _http.PutAsJsonAsync($"api/users/{user.Id}", user);
            await GetUsers();
            _navigationManager.NavigateTo("users");
        }
    }
}
