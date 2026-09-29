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
    public class AssetTransfersController : ControllerBase
    {
        private readonly IAssetTransferService _service;

        public AssetTransfersController(IAssetTransferService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<AssetTransferDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<AssetTransferDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<AssetTransferDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<AssetTransferDto>.Fail("Not found"));
            return Ok(ApiResponse<AssetTransferDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<AssetTransferDto>>> Create([FromBody] AssetTransferDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<AssetTransferDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] AssetTransferDto dto)
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
