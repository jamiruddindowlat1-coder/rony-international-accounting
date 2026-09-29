using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Payroll;
using InternationalAccountingSystem.API.Services.Interfaces.Payroll;

namespace InternationalAccountingSystem.API.Controllers.Payroll
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PayrollTransactionsController : ControllerBase
    {
        private readonly IPayrollTransactionService _service;

        public PayrollTransactionsController(IPayrollTransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<PayrollTransactionDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<PayrollTransactionDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<PayrollTransactionDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<PayrollTransactionDto>.Fail("Not found"));
            return Ok(ApiResponse<PayrollTransactionDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<PayrollTransactionDto>>> Create([FromBody] PayrollTransactionDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<PayrollTransactionDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] PayrollTransactionDto dto)
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
