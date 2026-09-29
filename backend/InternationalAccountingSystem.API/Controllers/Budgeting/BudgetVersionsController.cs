using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Budgeting;
using InternationalAccountingSystem.API.Services.Interfaces.Budgeting;

namespace InternationalAccountingSystem.API.Controllers.Budgeting
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class BudgetVersionsController : ControllerBase
    {
        private readonly IBudgetVersionService _service;

        public BudgetVersionsController(IBudgetVersionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<BudgetVersionDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<BudgetVersionDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<BudgetVersionDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<BudgetVersionDto>.Fail("Not found"));
            return Ok(ApiResponse<BudgetVersionDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<BudgetVersionDto>>> Create([FromBody] BudgetVersionDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<BudgetVersionDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] BudgetVersionDto dto)
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
