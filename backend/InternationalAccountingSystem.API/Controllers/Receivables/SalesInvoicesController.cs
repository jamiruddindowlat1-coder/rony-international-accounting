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
    public class SalesInvoicesController : ControllerBase
    {
        private readonly ISalesInvoiceService _service;

        public SalesInvoicesController(ISalesInvoiceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<SalesInvoiceDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<SalesInvoiceDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<SalesInvoiceDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<SalesInvoiceDto>.Fail("Not found"));
            return Ok(ApiResponse<SalesInvoiceDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<SalesInvoiceDto>>> Create([FromBody] SalesInvoiceDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<SalesInvoiceDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] SalesInvoiceDto dto)
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
