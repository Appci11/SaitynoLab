using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaitynoLab.Shared.Dto;
using SaitynoLab.Server.Services.PartsService;
using SaitynoLab.Shared;
using System.Data;

namespace SaitynoLab.Server.Controllers
{
    [Route("api/orders/{orderId}/furniture/{furnitureId}/[controller]")]
    [ApiController]
    public class PartsController : ControllerBase
    {
        private readonly IPartsService _partsService;

        public PartsController(IPartsService partsService)
        {
            _partsService = partsService;
        }

        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllParts(int orderId, int furnitureId)
        {
            List<Part> response = await _partsService.GetAllParts(orderId, furnitureId);
            if (response == null || response.Count < 1)
            {
                return NotFound(new { message = "Bad id provided or nothing found" });
            }
            return Ok(response);
        }
        [HttpGet("{partId}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetPart(int orderId, int furnitureId, int partId)
        {
            Part response = await _partsService.GetPart(orderId, furnitureId, partId);
            if (response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "Bad id provided or nothing found" });
        }
        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddPart(int orderId, int furnitureId, PartCreateDto partCreateDto)
        {
            Part response = await _partsService.AddPart(orderId, furnitureId, partCreateDto);
            {
                if (response != null)
                {
                    return Created($"/api/orders/{orderId}/furniture/{furnitureId}/parts/{response.Id}", response);
                }
                else return NotFound(new { message = "Part was not created" });
            }
        }
        [HttpPut("{partId}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdatePart(int orderId, int furnitureId,
            int partId, PartUpdateDto partUpdateDto)
        {
            Part response = await _partsService.UpdatePart(orderId, furnitureId, partId, partUpdateDto);
            if (response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "Part was not updated" });
        }
        [HttpDelete("{partId}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePart(int orderId, int furnitureId, int partId)
        {
            Part response = await _partsService.DeletePart(orderId, furnitureId, partId);
            if (response != null)
            {
                return Ok(response);
            }
            else return NotFound(new { message = "Part not found. Action aborted" });
        }
    }
}
