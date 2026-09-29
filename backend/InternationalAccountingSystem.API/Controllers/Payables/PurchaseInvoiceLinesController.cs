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
    public class PurchaseInvoiceLinesController : ControllerBase
    {
        private readonly IPurchaseInvoiceLineService _service;

        public PurchaseInvoiceLinesController(IPurchaseInvoiceLineService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<PurchaseInvoiceLineDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<PurchaseInvoiceLineDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<PurchaseInvoiceLineDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<PurchaseInvoiceLineDto>.Fail("Not found"));
            return Ok(ApiResponse<PurchaseInvoiceLineDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<PurchaseInvoiceLineDto>>> Create([FromBody] PurchaseInvoiceLineDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<PurchaseInvoiceLineDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] PurchaseInvoiceLineDto dto)
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
