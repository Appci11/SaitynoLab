using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaitynoLab.Shared.Dto;
using SaitynoLab.Server.Services.FurnitureService;
using SaitynoLab.Shared;
using System.Data;

namespace SaitynoLab.Server.Controllers
{
    [Route("api/orders/{orderId}/[controller]")]
    [ApiController]
    [Authorize(Roles = "RegisteredUser")]
    public class FurnitureController : ControllerBase
    {
        private readonly IFurnitureService _furnitureService;

        public FurnitureController(IFurnitureService furnitureService)
        {
            _furnitureService = furnitureService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFurniture(int orderId)
        {
            List<Furniture> response = await _furnitureService.GetAllFurniture(orderId);
            if (response.Count > 0)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "No order with such id or order has no furniture added" });
        }
        [HttpGet("{furnitureId}")]
        public async Task<ActionResult<Furniture>> GetFurniture(int orderId, int furnitureId)
        {
            Furniture response = await _furnitureService.GetFurniture(orderId, furnitureId);
            if(response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "Furniture not found" });
        }
        [HttpPost]
        public async Task<IActionResult> AddFurniture(int orderId, FurnitureCreateDto furnitureCreateDto)
        {
            Furniture response = await _furnitureService.AddFurniture(orderId, furnitureCreateDto);
            if (response != null)
            {
                return Created($"/api/orders/{orderId}/furniture/{response.Id}", response);
            }
            else return NotFound(new { message = "Order was not created" });
        }
        [HttpPut("{furnitureId}")]
        public async Task<IActionResult> UpdateFurniture(int orderId, int furnitureId, FurnitureUpdateDto furnitureUpdateDto)
        {
            Furniture response = await _furnitureService.UpdateFurniture(orderId, furnitureId, furnitureUpdateDto);
            if(response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "Order or furniture not found" });
        }
        [HttpDelete("{furnitureId}")]
        public async Task<IActionResult> DeleteFurniture(int orderId, int furnitureId)
        {
            Furniture response = await _furnitureService.DeleteFurniture(orderId, furnitureId);
            if(response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "Order or furniture not found" });
        }
    }
}
