using SaitynoLab.Server.Dto;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Services.FurnitureService
{
    public interface IFurnitureService
    {
        Task<Furniture> AddFurniture(int orderId, FurnitureCreateDto furnitureCreateDto);
        Task<List<Furniture>> GetAllFurniture(int orderId);
        Task<Furniture> GetFurniture(int orderId, int furnitureId);
        Task<Furniture> UpdateFurniture(int orderId, int furnitureId, FurnitureUpdateDto furnitureUpdateDto);
        Task<Furniture> DeleteFurniture(int orderId, int furnitureId);
    }
}
