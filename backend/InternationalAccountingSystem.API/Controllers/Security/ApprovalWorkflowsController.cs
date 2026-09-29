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
    public class ApprovalWorkflowsController : ControllerBase
    {
        private readonly IApprovalWorkflowService _service;

        public ApprovalWorkflowsController(IApprovalWorkflowService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<ApprovalWorkflowDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<ApprovalWorkflowDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<ApprovalWorkflowDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<ApprovalWorkflowDto>.Fail("Not found"));
            return Ok(ApiResponse<ApprovalWorkflowDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<ApprovalWorkflowDto>>> Create([FromBody] ApprovalWorkflowDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<ApprovalWorkflowDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] ApprovalWorkflowDto dto)
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
