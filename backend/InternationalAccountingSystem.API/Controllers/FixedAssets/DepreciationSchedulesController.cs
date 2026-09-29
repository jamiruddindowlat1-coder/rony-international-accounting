using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.FixedAssets;
using InternationalAccountingSystem.API.Services.Interfaces.FixedAssets;

namespace InternationalAccountingSystem.API.Controllers.FixedAssets
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class DepreciationSchedulesController : ControllerBase
    {
        private readonly IDepreciationScheduleService _service;

        public DepreciationSchedulesController(IDepreciationScheduleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<DepreciationScheduleDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<DepreciationScheduleDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<DepreciationScheduleDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<DepreciationScheduleDto>.Fail("Not found"));
            return Ok(ApiResponse<DepreciationScheduleDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<DepreciationScheduleDto>>> Create([FromBody] DepreciationScheduleDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<DepreciationScheduleDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] DepreciationScheduleDto dto)
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
