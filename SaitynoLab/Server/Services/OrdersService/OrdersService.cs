using Microsoft.EntityFrameworkCore;
using SaitynoLab.Server.Data;
using SaitynoLab.Server.Dto;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Services.OrdersService
{
    public class OrdersService : IOrdersService
    {
        private readonly DataContext _context;

        public OrdersService(DataContext context)
        {
            _context = context;
        }

        public async Task<Order> AddOrder(OrderCreateDto orderCreateDto)
        {
            Order order = new ();
            order.BuyerId = orderCreateDto.BuyerId;
            order.Email = orderCreateDto.Email;
            order.PhoneNumber = orderCreateDto.PhoneNumber;
            order.IsCompleted = orderCreateDto.IsCompleted;
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<Order> DeleteOrder(int id)
        {
            Order dbOrder = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if (dbOrder == null)
            {
                return null;
            }
            //cascade delete if FK found
            List<Furniture> furnitureList = await _context.Furniture
                .Where(f => f.OrderId == id)
                .ToListAsync();
            if (furnitureList.Count > 0)
            {
                foreach (Furniture fur in furnitureList)
                {
                    List<Part> partsList = await _context.Parts
                        .Where(p => p.FurnitureId == fur.Id)
                        .ToListAsync();
                    if (partsList.Count > 0)
                    {
                        foreach(Part part in partsList)
                        {
                            _context.Parts.Remove(part);
                        }
                    }
                    _context.Furniture.Remove(fur);
                }
            }
            _context.Orders.Remove(dbOrder);
            await _context.SaveChangesAsync();
            return dbOrder;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetOrder(int id)
        {
            Order? order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);
            return order;
        }

        public async Task<Order> UdateOrder(int id, OrderUpdateDto orderUpdateDto)
        {
            Order dbOrder = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if (dbOrder == null)
            {
                return null;
            }
            dbOrder.Email = orderUpdateDto.Email;
            dbOrder.PhoneNumber = orderUpdateDto.PhoneNumber;
            dbOrder.IsCompleted = orderUpdateDto.IsCompleted;
            await _context.SaveChangesAsync();
            return dbOrder;
        }
    }
}
