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
    public class BankStatementImportsController : ControllerBase
    {
        private readonly IBankStatementImportService _service;

        public BankStatementImportsController(IBankStatementImportService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<BankStatementImportDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<BankStatementImportDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<BankStatementImportDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<BankStatementImportDto>.Fail("Not found"));
            return Ok(ApiResponse<BankStatementImportDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<BankStatementImportDto>>> Create([FromBody] BankStatementImportDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<BankStatementImportDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] BankStatementImportDto dto)
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
