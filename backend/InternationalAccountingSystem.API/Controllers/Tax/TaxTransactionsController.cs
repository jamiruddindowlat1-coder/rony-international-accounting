using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Tax;
using InternationalAccountingSystem.API.Services.Interfaces.Tax;

namespace InternationalAccountingSystem.API.Controllers.Tax
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TaxTransactionsController : ControllerBase
    {
        private readonly ITaxTransactionService _service;

        public TaxTransactionsController(ITaxTransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<TaxTransactionDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<TaxTransactionDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<TaxTransactionDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<TaxTransactionDto>.Fail("Not found"));
            return Ok(ApiResponse<TaxTransactionDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<TaxTransactionDto>>> Create([FromBody] TaxTransactionDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<TaxTransactionDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] TaxTransactionDto dto)
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
