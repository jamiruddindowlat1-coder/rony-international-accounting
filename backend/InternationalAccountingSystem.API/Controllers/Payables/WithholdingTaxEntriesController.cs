using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Payables;
using InternationalAccountingSystem.API.Services.Interfaces.Payables;

namespace InternationalAccountingSystem.API.Controllers.Payables
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class WithholdingTaxEntriesController : ControllerBase
    {
        private readonly IWithholdingTaxEntryService _service;

        public WithholdingTaxEntriesController(IWithholdingTaxEntryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<WithholdingTaxEntryDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<WithholdingTaxEntryDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<WithholdingTaxEntryDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<WithholdingTaxEntryDto>.Fail("Not found"));
            return Ok(ApiResponse<WithholdingTaxEntryDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<WithholdingTaxEntryDto>>> Create([FromBody] WithholdingTaxEntryDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<WithholdingTaxEntryDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] WithholdingTaxEntryDto dto)
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
