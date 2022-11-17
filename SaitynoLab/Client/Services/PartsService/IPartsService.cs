namespace SaitynoLab.Client.Services.PartsService
{
    public interface IPartsService
    {
        List<Part> Parts { get; set; }

        Task GetParts(int orderId, int furnitureId);
        Task<Part> GetSinglePart(int orderId, int furnitureId, int id);
        Task CreatePart(int orderId, int furnitureId, Furniture furniture);
        Task UpdatePart(int orderId, int furnitureId, Furniture furniture);
        Task DeletePart(int orderId, int furnitureId, int id);
    }
}
