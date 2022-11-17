namespace SaitynoLab.Client.Services.FurnitureService
{
    public interface IFurnitureService
    {
        List<Furniture> Furniture { get; set; }

        Task GetAllFurniture(int orderId);
        Task<Furniture> GetSingleFurniture(int orderId, int id);
        Task CreateFurniture(int orderId, Furniture furniture);
        Task UpdateFurniture(int orderId, Furniture furniture);
        Task DeleteFurniture(int orderId, int id);
    }
}
