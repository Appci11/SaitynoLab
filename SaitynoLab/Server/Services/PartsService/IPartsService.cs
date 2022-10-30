using SaitynoLab.Shared.Dto;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Services.PartsService
{
    public interface IPartsService
    {
        Task<List<Part>> GetAllParts(int orderId, int furnitureId);
        Task<Part> GetPart(int orderId, int furnitureId, int partId);
        Task<Part> AddPart(int orderId, int furnitureId, PartCreateDto partCreateDto);
        Task<Part> UpdatePart(int orderId, int furnitureId, int partId, PartUpdateDto partUpdateDto);
        Task<Part> DeletePart(int orderId, int furnitureId, int partId);
    }
}
