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
    public class StockTransactionsController : ControllerBase
    {
        private readonly IStockTransactionService _service;

        public StockTransactionsController(IStockTransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<StockTransactionDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<StockTransactionDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<StockTransactionDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<StockTransactionDto>.Fail("Not found"));
            return Ok(ApiResponse<StockTransactionDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<StockTransactionDto>>> Create([FromBody] StockTransactionDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<StockTransactionDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] StockTransactionDto dto)
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
