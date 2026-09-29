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
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _service;

        public NotificationsController(INotificationService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<NotificationDto>>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<NotificationDto>>.Ok(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<NotificationDto>>> GetById(long id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null) return NotFound(ApiResponse<NotificationDto>.Fail("Not found"));
            return Ok(ApiResponse<NotificationDto>.Ok(data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<NotificationDto>>> Create([FromBody] NotificationDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(ApiResponse<NotificationDto>.Ok(created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Update(long id, [FromBody] NotificationDto dto)
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
