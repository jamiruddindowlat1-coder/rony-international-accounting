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
    public class FixedAssetsController : ControllerBase
    {
        private readonly IFixedAssetService _service;

        public FixedAssetsController(IFixedAssetService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<FixedAssetDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<FixedAssetDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<FixedAssetDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<FixedAssetDto>.Fail("Not found"));
            return Ok(ApiResponse<FixedAssetDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<FixedAssetDto>>> Create([FromBody] FixedAssetDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<FixedAssetDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] FixedAssetDto dto)
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
