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
            var result = await _http.PostAsJsonAsync($"{Settings.Url}/api/users", user);
            //await GetUsers();  //kazi ar bereikia, iejus i /users turetu ir taip pasileist
            _navigationManager.NavigateTo($"{Settings.Url2}/users");
        }

        public async Task DeleteUser(int id)
        {
            var result = await _http.DeleteAsync($"{Settings.Url}/api/users/{id}");
            //await GetUsers();
            _navigationManager.NavigateTo($"{Settings.Url2}/users");
        }

        public async Task<User> GetSingleUser(int id)
        {
            var result = await _http.GetFromJsonAsync<User>($"{Settings.Url}/api/users/{id}");
            if (result != null)
            {
                return result;
            }
            throw new Exception("User not found");
        }

        public async Task GetUsers()
        {
            var result = await _http.GetFromJsonAsync<List<User>>($"{Settings.Url}/api/users");
            if (result != null)
            {
                Users = result;
            }
        }

        public async Task UpdateUser(User user)
        {
            var result = await _http.PutAsJsonAsync($"{Settings.Url}/api/users/{user.Id}", user);
            //await GetUsers();
            _navigationManager.NavigateTo($"{Settings.Url2}/users");
        }
    }
}
