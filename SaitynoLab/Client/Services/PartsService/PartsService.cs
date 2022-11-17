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

        public async Task CreatePart(int orderId, int furnitureId, Furniture furniture)
        {
            throw new NotImplementedException();
        }

        public async Task DeletePart(int orderId, int furnitureId, int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public async Task UpdatePart(int orderId, int furnitureId, Furniture furniture)
        {
            throw new NotImplementedException();
        }
    }
}
