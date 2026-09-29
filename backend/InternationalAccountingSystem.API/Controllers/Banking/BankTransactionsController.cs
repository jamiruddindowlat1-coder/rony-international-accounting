using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Banking;
using InternationalAccountingSystem.API.Services.Interfaces.Banking;

namespace InternationalAccountingSystem.API.Controllers.Banking
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class BankTransactionsController : ControllerBase
    {
        private readonly IBankTransactionService _service;

        public BankTransactionsController(IBankTransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<BankTransactionDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<BankTransactionDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<BankTransactionDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<BankTransactionDto>.Fail("Not found"));
            return Ok(ApiResponse<BankTransactionDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<BankTransactionDto>>> Create([FromBody] BankTransactionDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<BankTransactionDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] BankTransactionDto dto)
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
