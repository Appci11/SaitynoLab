using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace SaitynoLab.Client.Services.PartsService
{
    public class PartsService : IPartsService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public PartsService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Part> Parts { get; set; } = new List<Part>();

        public async Task CreatePart(int orderId, int furnitureId, Part part)
        {
            var result = await _http.PostAsJsonAsync($"api/orders/{orderId}/furniture/{furnitureId}/parts", part);
            _navigationManager.NavigateTo($"orders/{orderId}/allfurniture/{furnitureId}/parts");
        }

        public async Task DeletePart(int orderId, int furnitureId, int id)
        {
            var result = await _http.DeleteAsync($"api/orders/{orderId}/furniture/{furnitureId}/parts/{id}");
            _navigationManager.NavigateTo($"orders/{orderId}/allfurniture/{furnitureId}/parts");
        }

        public async Task GetParts(int orderId, int furnitureId)
        {
            List<Part> result = null;
            try
            {
                result = await _http.GetFromJsonAsync<List<Part>>($"api/orders/{orderId}/furniture/{furnitureId}/parts");
            }
            catch (Exception e) { };
            if (result != null)
            {
                Parts = result;
            }
        }

        public async Task<Part> GetSinglePart(int orderId, int furnitureId, int id)
        {
            Part result = null;
            try
            {
                result = await _http.GetFromJsonAsync<Part>($"/api/orders/{orderId}/furniture/{furnitureId}/parts/{id}");
            }
            catch (Exception e) { };
            return result;
        }

        public async Task UpdatePart(int orderId, int furnitureId, Part part)
        {
            var result = await _http.PutAsJsonAsync($"/api/orders/{orderId}/furniture/{furnitureId}/parts/{part.Id}", part);
            _navigationManager.NavigateTo($"orders/{orderId}/allfurniture/{furnitureId}/parts");
        }
    }
}
