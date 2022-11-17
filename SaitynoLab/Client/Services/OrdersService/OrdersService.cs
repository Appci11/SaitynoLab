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

        public Task CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetOrders()
        {
            List<Order> result = null;
            try
            {
                result = await _http.GetFromJsonAsync<List<Order>>("api/orders");
            }
            catch (Exception e) { };
            if (result != null)
            {
                Orders = result;
            }
        }

        public Task<Order> GetSingleOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
