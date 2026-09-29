using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Payables;
using InternationalAccountingSystem.API.Services.Interfaces.Payables;

namespace InternationalAccountingSystem.API.Controllers.Payables
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PurchaseInvoicesController : ControllerBase
    {
        private readonly IPurchaseInvoiceService _service;

        public PurchaseInvoicesController(IPurchaseInvoiceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<PurchaseInvoiceDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<PurchaseInvoiceDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<PurchaseInvoiceDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<PurchaseInvoiceDto>.Fail("Not found"));
            return Ok(ApiResponse<PurchaseInvoiceDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<PurchaseInvoiceDto>>> Create([FromBody] PurchaseInvoiceDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<PurchaseInvoiceDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] PurchaseInvoiceDto dto)
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
