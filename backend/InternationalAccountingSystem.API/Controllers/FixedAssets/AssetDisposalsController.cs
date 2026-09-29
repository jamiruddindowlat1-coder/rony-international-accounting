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
    public class AssetDisposalsController : ControllerBase
    {
        private readonly IAssetDisposalService _service;

        public AssetDisposalsController(IAssetDisposalService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<AssetDisposalDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<AssetDisposalDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<AssetDisposalDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<AssetDisposalDto>.Fail("Not found"));
            return Ok(ApiResponse<AssetDisposalDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<AssetDisposalDto>>> Create([FromBody] AssetDisposalDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<AssetDisposalDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] AssetDisposalDto dto)
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
