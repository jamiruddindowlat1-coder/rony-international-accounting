using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Core;
using InternationalAccountingSystem.API.Services.Interfaces.Core;

namespace InternationalAccountingSystem.API.Controllers.Core
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class AccountingPeriodsController : ControllerBase
    {
        private readonly IAccountingPeriodService _service;

        public AccountingPeriodsController(IAccountingPeriodService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<AccountingPeriodDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<AccountingPeriodDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<AccountingPeriodDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<AccountingPeriodDto>.Fail("Not found"));
            return Ok(ApiResponse<AccountingPeriodDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<AccountingPeriodDto>>> Create([FromBody] AccountingPeriodDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<AccountingPeriodDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] AccountingPeriodDto dto)
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
