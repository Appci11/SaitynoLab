using SaitynoLab.Server.Dto;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Services.OrdersService
{
    public interface IOrdersService
    {
        Task<Order> AddOrder(OrderCreateDto orderCreateDto);
        Task<Order> GetOrder(int id);
        Task<List<Order>> GetAllOrders();
        Task<Order> UdateOrder(int id, OrderUpdateDto orderUpdateDto);
        Task<Order> DeleteOrder(int id);
    }
}
