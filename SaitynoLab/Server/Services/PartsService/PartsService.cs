using Microsoft.EntityFrameworkCore;
using SaitynoLab.Server.Data;
using SaitynoLab.Server.Dto;
using SaitynoLab.Server.Services.FurnitureService;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Services.PartsService
{
    public class PartsService : IPartsService
    {
        private readonly DataContext _context;
        private readonly IFurnitureService _furnitureService;

        public PartsService(DataContext context, IFurnitureService furnitureService)
        {
            _context = context;
            _furnitureService = furnitureService;
        }

        public async Task<Part> AddPart(int orderId, int furnitureId, PartCreateDto partCreateDto)
        {
            Furniture check = await _furnitureService.GetFurniture(orderId, furnitureId);
            if (check == null)
            {
                return null;
            }
            Part part = new();
            part.FurnitureId = furnitureId;
            part.Name = partCreateDto.Name;
            part.Price = partCreateDto.Price;
            part.Color = partCreateDto.Color;
            _context.Parts.Add(part);
            await _context.SaveChangesAsync();
            return part;
        }

        public async Task<Part> DeletePart(int orderId, int furnitureId, int partId)
        {
            Part dbPart = await GetPart(orderId, furnitureId, partId);
            if (dbPart == null)
            {
                return null;
            }
            _context.Parts.Remove(dbPart);
            await _context.SaveChangesAsync();
            return dbPart;
        }

        public async Task<List<Part>> GetAllParts(int orderId, int furnitureId)
        {
            Furniture check = await _furnitureService.GetFurniture(orderId, furnitureId);
            if(check == null)
            {
                return null;
            }
            return await _context.Parts
                .Where(p => p.FurnitureId == furnitureId)
                .ToListAsync();
        }

        public async Task<Part> GetPart(int orderId, int furnitureId, int partId)
        {
            Furniture check = await _furnitureService.GetFurniture(orderId, furnitureId);
            if (check == null)
            {
                return null;
            }
            Part? part = await _context.Parts
                .FirstOrDefaultAsync(p => p.FurnitureId == furnitureId && p.Id == partId);
            return part;


            throw new NotImplementedException();
        }

        public async Task<Part> UpdatePart(int orderId, int furnitureId, int partId, PartUpdateDto partUpdateDto)
        {
            Part dbPart = await GetPart(orderId, furnitureId, partId);
            if (dbPart == null)
            {
                return null;
            }
            dbPart.Name = partUpdateDto.Name;
            dbPart.Price = partUpdateDto.Price;
            dbPart.Color = partUpdateDto.Color;
            await _context.SaveChangesAsync();
            return dbPart;
        }
    }
}
