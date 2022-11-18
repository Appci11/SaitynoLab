using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace SaitynoLab.Client.Services.OrdersService
{
    public class OrdersService : IOrdersService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public OrdersService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<Order> Orders { get; set; } = new List<Order>();

        public async Task CreateOrder(Order order)
        {
            var result = await _http.PostAsJsonAsync($"{Settings.Url}/api/orders", order);
            //await GetOrders();
            _navigationManager.NavigateTo($"{Settings.Url2}/orders");
        }

        public async Task DeleteOrder(int id)
        {
            var result = await _http.DeleteAsync($"{Settings.Url}/api/orders/{id}");
            //await GetOrders();
            _navigationManager.NavigateTo($"{Settings.Url2}/orders");
        }

        public async Task GetOrders()
        {
            List<Order> result = null;
            try
            {
                result = await _http.GetFromJsonAsync<List<Order>>($"{Settings.Url}/api/orders");
            }
            catch (Exception e) { };
            if (result != null)
            {
                Orders = result;
            }
        }

        public async Task<Order> GetSingleOrder(int id)
        {
            Order result = null;
            try
            {
                result = await _http.GetFromJsonAsync<Order>($"{Settings.Url}/api/orders/{id}");
            }
            catch (Exception e) { };
            return result;
        }

        public async Task UpdateOrder(Order order)
        {
            var result = await _http.PutAsJsonAsync($"{Settings.Url}/api/orders/{order.Id}", order);
            //await GetOrders();
            _navigationManager.NavigateTo($"{Settings.Url2}/orders");
        }
    }
}
