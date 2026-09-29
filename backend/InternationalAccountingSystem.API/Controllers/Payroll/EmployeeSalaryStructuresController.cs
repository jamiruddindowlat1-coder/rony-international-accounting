using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Payroll;
using InternationalAccountingSystem.API.Services.Interfaces.Payroll;

namespace InternationalAccountingSystem.API.Controllers.Payroll
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EmployeeSalaryStructuresController : ControllerBase
    {
        private readonly IEmployeeSalaryStructureService _service;

        public EmployeeSalaryStructuresController(IEmployeeSalaryStructureService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<EmployeeSalaryStructureDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<EmployeeSalaryStructureDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<EmployeeSalaryStructureDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<EmployeeSalaryStructureDto>.Fail("Not found"));
            return Ok(ApiResponse<EmployeeSalaryStructureDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<EmployeeSalaryStructureDto>>> Create([FromBody] EmployeeSalaryStructureDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<EmployeeSalaryStructureDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] EmployeeSalaryStructureDto dto)
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
