using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Dimensions;
using InternationalAccountingSystem.API.Services.Interfaces.Dimensions;

namespace InternationalAccountingSystem.API.Controllers.Dimensions
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CostCentersController : ControllerBase
    {
        private readonly ICostCenterService _service;

        public CostCentersController(ICostCenterService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<CostCenterDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<CostCenterDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<CostCenterDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<CostCenterDto>.Fail("Not found"));
            return Ok(ApiResponse<CostCenterDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<CostCenterDto>>> Create([FromBody] CostCenterDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<CostCenterDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] CostCenterDto dto)
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
