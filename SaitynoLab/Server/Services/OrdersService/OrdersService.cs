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

        public async Task<Order> AddOrder(Order order)
        {
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
