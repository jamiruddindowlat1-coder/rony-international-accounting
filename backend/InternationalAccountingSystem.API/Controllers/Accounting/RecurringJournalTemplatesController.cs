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
    public class RecurringJournalTemplatesController : ControllerBase
    {
        private readonly IRecurringJournalTemplateService _service;

        public RecurringJournalTemplatesController(IRecurringJournalTemplateService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<RecurringJournalTemplateDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<RecurringJournalTemplateDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<RecurringJournalTemplateDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<RecurringJournalTemplateDto>.Fail("Not found"));
            return Ok(ApiResponse<RecurringJournalTemplateDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<RecurringJournalTemplateDto>>> Create([FromBody] RecurringJournalTemplateDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<RecurringJournalTemplateDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] RecurringJournalTemplateDto dto)
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
