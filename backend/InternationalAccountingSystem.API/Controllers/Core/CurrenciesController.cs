using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Core;
using InternationalAccountingSystem.API.Services.Interfaces.Core;

namespace InternationalAccountingSystem.API.Controllers.Core
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CurrenciesController : ControllerBase
    {
        private readonly ICurrencyService _service;

        public CurrenciesController(ICurrencyService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<CurrencyDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<CurrencyDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<CurrencyDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<CurrencyDto>.Fail("Not found"));
            return Ok(ApiResponse<CurrencyDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<CurrencyDto>>> Create([FromBody] CurrencyDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<CurrencyDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] CurrencyDto dto)
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
