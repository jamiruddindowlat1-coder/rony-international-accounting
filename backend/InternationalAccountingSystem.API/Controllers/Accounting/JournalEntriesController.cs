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
    public class JournalEntriesController : ControllerBase
    {
        private readonly IJournalEntryService _service;

        public JournalEntriesController(IJournalEntryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<JournalEntryDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<JournalEntryDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<JournalEntryDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<JournalEntryDto>.Fail("Not found"));
            return Ok(ApiResponse<JournalEntryDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<JournalEntryDto>>> Create([FromBody] JournalEntryDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<JournalEntryDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] JournalEntryDto dto)
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
