namespace SaitynoLab.Client.Services.OrdersService
{
    public interface IOrdersService
    {
        List<Order> Orders { get; set; }

        Task GetOrders();
        Task<Order> GetSingleOrder(int id);
        Task CreateOrder(Order order);
        Task UpdateOrder(Order order);
        Task DeleteOrder(int id);
    }
}
