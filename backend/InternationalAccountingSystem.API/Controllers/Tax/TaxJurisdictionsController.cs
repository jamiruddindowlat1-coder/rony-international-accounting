using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Tax;
using InternationalAccountingSystem.API.Services.Interfaces.Tax;

namespace InternationalAccountingSystem.API.Controllers.Tax
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TaxJurisdictionsController : ControllerBase
    {
        private readonly ITaxJurisdictionService _service;

        public TaxJurisdictionsController(ITaxJurisdictionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<TaxJurisdictionDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<TaxJurisdictionDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<TaxJurisdictionDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<TaxJurisdictionDto>.Fail("Not found"));
            return Ok(ApiResponse<TaxJurisdictionDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<TaxJurisdictionDto>>> Create([FromBody] TaxJurisdictionDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<TaxJurisdictionDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] TaxJurisdictionDto dto)
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
