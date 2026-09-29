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
    public class BankAccountsController : ControllerBase
    {
        private readonly IBankAccountService _service;

        public BankAccountsController(IBankAccountService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<BankAccountDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<BankAccountDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<BankAccountDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<BankAccountDto>.Fail("Not found"));
            return Ok(ApiResponse<BankAccountDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<BankAccountDto>>> Create([FromBody] BankAccountDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<BankAccountDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] BankAccountDto dto)
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
