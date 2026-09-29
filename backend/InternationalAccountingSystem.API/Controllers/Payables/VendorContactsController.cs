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
    public class VendorContactsController : ControllerBase
    {
        private readonly IVendorContactService _service;

        public VendorContactsController(IVendorContactService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<VendorContactDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<VendorContactDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<VendorContactDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<VendorContactDto>.Fail("Not found"));
            return Ok(ApiResponse<VendorContactDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<VendorContactDto>>> Create([FromBody] VendorContactDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<VendorContactDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] VendorContactDto dto)
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
