using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternationalAccountingSystem.API.Common;
using InternationalAccountingSystem.API.Dtos.Notifications;
using InternationalAccountingSystem.API.Services.Interfaces.Notifications;

namespace InternationalAccountingSystem.API.Controllers.Notifications
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SmsQueueItemsController : ControllerBase
    {
        private readonly ISmsQueueItemService _service;

        public SmsQueueItemsController(ISmsQueueItemService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<SmsQueueItemDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<SmsQueueItemDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<SmsQueueItemDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<SmsQueueItemDto>.Fail("Not found"));
            return Ok(ApiResponse<SmsQueueItemDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<SmsQueueItemDto>>> Create([FromBody] SmsQueueItemDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<SmsQueueItemDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] SmsQueueItemDto dto)
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
