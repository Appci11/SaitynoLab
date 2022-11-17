using Microsoft.AspNetCore.Components;
using SaitynoLab.Client.Pages.Orders;
using System.Net.Http.Json;

namespace SaitynoLab.Client.Services.FurnitureService
{
    public class FurnitureService : IFurnitureService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public FurnitureService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<Furniture> Furniture { get; set; } = new List<Furniture>();

        public async Task CreateFurniture(int orderId, Furniture furniture)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteFurniture(int orderId, int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetAllFurniture(int orderId)
        {
            List<Furniture> result = null;
            try
            {
                result = await _http.GetFromJsonAsync<List<Furniture>>($"api/orders/{orderId}/furniture");
            }
            catch (Exception e) { };
            if (result != null)
            {
                Furniture = result;
            }
        }

        public async Task<Furniture> GetSingleFurniture(int orderId, int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateFurniture(int orderId, Furniture furniture)
        {
            throw new NotImplementedException();
        }
    }
}
