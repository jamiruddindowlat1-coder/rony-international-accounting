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
    public class AssetMaintenanceLogsController : ControllerBase
    {
        private readonly IAssetMaintenanceLogService _service;

        public AssetMaintenanceLogsController(IAssetMaintenanceLogService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<AssetMaintenanceLogDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<AssetMaintenanceLogDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<AssetMaintenanceLogDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<AssetMaintenanceLogDto>.Fail("Not found"));
            return Ok(ApiResponse<AssetMaintenanceLogDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<AssetMaintenanceLogDto>>> Create([FromBody] AssetMaintenanceLogDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<AssetMaintenanceLogDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] AssetMaintenanceLogDto dto)
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
