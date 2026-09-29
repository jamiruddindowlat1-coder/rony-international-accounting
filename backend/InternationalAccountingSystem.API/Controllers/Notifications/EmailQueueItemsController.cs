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
    public class EmailQueueItemsController : ControllerBase
    {
        private readonly IEmailQueueItemService _service;

        public EmailQueueItemsController(IEmailQueueItemService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<EmailQueueItemDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<EmailQueueItemDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<EmailQueueItemDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<EmailQueueItemDto>.Fail("Not found"));
            return Ok(ApiResponse<EmailQueueItemDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<EmailQueueItemDto>>> Create([FromBody] EmailQueueItemDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<EmailQueueItemDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] EmailQueueItemDto dto)
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
