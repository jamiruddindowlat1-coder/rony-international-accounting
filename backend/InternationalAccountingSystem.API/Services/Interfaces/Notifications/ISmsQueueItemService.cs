using InternationalAccountingSystem.API.Entities.Notifications;
using InternationalAccountingSystem.API.Dtos.Notifications;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Notifications
{
    public interface ISmsQueueItemService : IGenericService<SmsQueueItem, SmsQueueItemDto>
    {
    }
}
