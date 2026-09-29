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
    public class EmployeeLoansController : ControllerBase
    {
        private readonly IEmployeeLoanService _service;

        public EmployeeLoansController(IEmployeeLoanService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<EmployeeLoanDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<EmployeeLoanDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<EmployeeLoanDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<EmployeeLoanDto>.Fail("Not found"));
            return Ok(ApiResponse<EmployeeLoanDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<EmployeeLoanDto>>> Create([FromBody] EmployeeLoanDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<EmployeeLoanDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] EmployeeLoanDto dto)
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
