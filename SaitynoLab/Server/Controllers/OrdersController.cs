using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaitynoLab.Server.Dto;
using SaitynoLab.Server.Services.OrdersService;
using SaitynoLab.Shared;

namespace SaitynoLab.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            List<Order> response = await _ordersService.GetAllOrders();
            if (response.Count > 0)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "No orders found" });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            Order response = await _ordersService.GetOrder(id);
            if (response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "Order not found" });
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(Order order)
        {
            Order response = await _ordersService.AddOrder(order);
            if (response != null)
            {
                return Created($"/api/orders/{response.Id}", response);
            }
            else return NotFound(new { message = "Order was not created" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, OrderUpdateDto orderUpdateDto)
        {
            Order response = await _ordersService.UdateOrder(id, orderUpdateDto);
            if (response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "Order not found" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            Order response = await _ordersService.DeleteOrder(id);
            if (response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "Order not found" });
        }
    }
}
