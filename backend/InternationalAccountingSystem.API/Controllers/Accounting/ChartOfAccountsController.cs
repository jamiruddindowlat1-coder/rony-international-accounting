using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Accounting;
using InternationalAccountingSystem.API.Services.Interfaces.Accounting;

namespace InternationalAccountingSystem.API.Controllers.Accounting
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ChartOfAccountsController : ControllerBase
    {
        private readonly IChartOfAccountService _service;

        public ChartOfAccountsController(IChartOfAccountService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<ChartOfAccountDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<ChartOfAccountDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<ChartOfAccountDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<ChartOfAccountDto>.Fail("Not found"));
            return Ok(ApiResponse<ChartOfAccountDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<ChartOfAccountDto>>> Create([FromBody] ChartOfAccountDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<ChartOfAccountDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] ChartOfAccountDto dto)
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
