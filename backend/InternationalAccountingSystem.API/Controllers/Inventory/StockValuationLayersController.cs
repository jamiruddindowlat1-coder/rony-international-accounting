using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Inventory;
using InternationalAccountingSystem.API.Services.Interfaces.Inventory;

namespace InternationalAccountingSystem.API.Controllers.Inventory
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class StockValuationLayersController : ControllerBase
    {
        private readonly IStockValuationLayerService _service;

        public StockValuationLayersController(IStockValuationLayerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<StockValuationLayerDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<StockValuationLayerDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<StockValuationLayerDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<StockValuationLayerDto>.Fail("Not found"));
            return Ok(ApiResponse<StockValuationLayerDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<StockValuationLayerDto>>> Create([FromBody] StockValuationLayerDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<StockValuationLayerDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] StockValuationLayerDto dto)
        {
            var success = await _service.UpdateAsync(id, dto);
            if (!success) return NotFound(ApiResponse<bool>.Fail("Not found"));
            return Ok(ApiResponse<bool>.Ok(true));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Delete(long id)
        {
            var success = await _service.DeleteAsync(id);
            if (!success) return NotFound(ApiResponse<bool>.Fail("Not found"));
            return Ok(ApiResponse<bool>.Ok(true));
        }
    }
}
