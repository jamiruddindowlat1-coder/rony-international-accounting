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
    public class ConsolidationMappingsController : ControllerBase
    {
        private readonly IConsolidationMappingService _service;

        public ConsolidationMappingsController(IConsolidationMappingService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<ConsolidationMappingDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<ConsolidationMappingDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<ConsolidationMappingDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<ConsolidationMappingDto>.Fail("Not found"));
            return Ok(ApiResponse<ConsolidationMappingDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<ConsolidationMappingDto>>> Create([FromBody] ConsolidationMappingDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<ConsolidationMappingDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] ConsolidationMappingDto dto)
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
