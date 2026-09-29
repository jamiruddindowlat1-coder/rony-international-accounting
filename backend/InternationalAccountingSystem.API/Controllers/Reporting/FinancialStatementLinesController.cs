using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Reporting;
using InternationalAccountingSystem.API.Services.Interfaces.Reporting;

namespace InternationalAccountingSystem.API.Controllers.Reporting
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class FinancialStatementLinesController : ControllerBase
    {
        private readonly IFinancialStatementLineService _service;

        public FinancialStatementLinesController(IFinancialStatementLineService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<FinancialStatementLineDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<FinancialStatementLineDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<FinancialStatementLineDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<FinancialStatementLineDto>.Fail("Not found"));
            return Ok(ApiResponse<FinancialStatementLineDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<FinancialStatementLineDto>>> Create([FromBody] FinancialStatementLineDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<FinancialStatementLineDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] FinancialStatementLineDto dto)
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
