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
    public class ExchangeRatesController : ControllerBase
    {
        private readonly IExchangeRateService _service;

        public ExchangeRatesController(IExchangeRateService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<ExchangeRateDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<ExchangeRateDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<ExchangeRateDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<ExchangeRateDto>.Fail("Not found"));
            return Ok(ApiResponse<ExchangeRateDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<ExchangeRateDto>>> Create([FromBody] ExchangeRateDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<ExchangeRateDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] ExchangeRateDto dto)
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
