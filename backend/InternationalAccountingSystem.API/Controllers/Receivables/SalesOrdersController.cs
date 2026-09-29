using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Receivables;
using InternationalAccountingSystem.API.Services.Interfaces.Receivables;

namespace InternationalAccountingSystem.API.Controllers.Receivables
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SalesOrdersController : ControllerBase
    {
        private readonly ISalesOrderService _service;

        public SalesOrdersController(ISalesOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<SalesOrderDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<SalesOrderDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<SalesOrderDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<SalesOrderDto>.Fail("Not found"));
            return Ok(ApiResponse<SalesOrderDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<SalesOrderDto>>> Create([FromBody] SalesOrderDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<SalesOrderDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] SalesOrderDto dto)
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
