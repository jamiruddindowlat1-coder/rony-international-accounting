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
    public class PettyCashTransactionsController : ControllerBase
    {
        private readonly IPettyCashTransactionService _service;

        public PettyCashTransactionsController(IPettyCashTransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<PettyCashTransactionDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<PettyCashTransactionDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<PettyCashTransactionDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<PettyCashTransactionDto>.Fail("Not found"));
            return Ok(ApiResponse<PettyCashTransactionDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<PettyCashTransactionDto>>> Create([FromBody] PettyCashTransactionDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<PettyCashTransactionDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] PettyCashTransactionDto dto)
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
