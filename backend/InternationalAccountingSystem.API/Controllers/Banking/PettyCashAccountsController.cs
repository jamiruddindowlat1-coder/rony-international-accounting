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
    public class PettyCashAccountsController : ControllerBase
    {
        private readonly IPettyCashAccountService _service;

        public PettyCashAccountsController(IPettyCashAccountService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<PettyCashAccountDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<PettyCashAccountDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<PettyCashAccountDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<PettyCashAccountDto>.Fail("Not found"));
            return Ok(ApiResponse<PettyCashAccountDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<PettyCashAccountDto>>> Create([FromBody] PettyCashAccountDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<PettyCashAccountDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] PettyCashAccountDto dto)
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
