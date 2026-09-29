using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Security;
using InternationalAccountingSystem.API.Services.Interfaces.Security;

namespace InternationalAccountingSystem.API.Controllers.Security
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PermissionsController : ControllerBase
    {
        private readonly IPermissionService _service;

        public PermissionsController(IPermissionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<PermissionDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<PermissionDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<PermissionDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<PermissionDto>.Fail("Not found"));
            return Ok(ApiResponse<PermissionDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<PermissionDto>>> Create([FromBody] PermissionDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<PermissionDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] PermissionDto dto)
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
