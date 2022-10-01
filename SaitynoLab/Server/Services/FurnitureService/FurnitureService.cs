using Microsoft.EntityFrameworkCore;
using SaitynoLab.Server.Data;
using SaitynoLab.Server.Dto;
using SaitynoLab.Server.Services.OrdersService;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Services.FurnitureService
{
    public class FurnitureService : IFurnitureService
    {
        private readonly DataContext _context;
        private readonly IOrdersService _ordersService;

        public FurnitureService(DataContext context, IOrdersService ordersService)
        {
            _context = context;
            _ordersService = ordersService;
        }
        public async Task<Furniture> AddFurniture(int orderId, Furniture furniture)
        {
            Order dbOrder = await _ordersService.GetOrder(orderId);
            if (dbOrder == null)
            {
                return null;
            }
            furniture.OrderId = orderId;
            _context.Furniture.Add(furniture);
            await _context.SaveChangesAsync();
            return furniture;
        }

        public async Task<Furniture> DeleteFurniture(int orderId, int furnitureId)
        {
            Order dbOrder = await _ordersService.GetOrder(orderId);
            if (dbOrder == null)
            {
                return null;
            }
            Furniture dbFurniture = await _context.Furniture.FirstOrDefaultAsync(
                f => f.Id == furnitureId && f.OrderId == orderId);
            if (dbFurniture == null)
            {
                return null;
            }
            _context.Furniture.Remove(dbFurniture);
            await _context.SaveChangesAsync();
            return dbFurniture;
        }

        public async Task<List<Furniture>> GetAllFurniture(int orderId)
        {
            return await _context.Furniture
                .Where(f => f.OrderId == orderId)
                .ToListAsync();
        }

        public async Task<Furniture> GetFurniture(int orderId, int furnitureId)
        {
            Furniture? furniture = await _context.Furniture
                .FirstOrDefaultAsync(f => f.Id == furnitureId && f.OrderId == orderId);
            return furniture;
        }

        public async Task<Furniture> UpdateFurniture(int orderId, int furnitureId, FurnitureUpdateDto furnitureUpdateDto)
        {
            Order dbOrder = await _ordersService.GetOrder(orderId);
            if (dbOrder == null)
            {
                return null;
            }
            Furniture dbFurniture = await _context.Furniture.FirstOrDefaultAsync(
                f => f.Id == furnitureId && f.OrderId == orderId);
            if (dbFurniture == null)
            {
                return null;
            }
            dbFurniture.Name = furnitureUpdateDto.Name;
            dbFurniture.ToAssemble = furnitureUpdateDto.ToAssemble;
            await _context.SaveChangesAsync();
            return dbFurniture;
        }
    }
}
