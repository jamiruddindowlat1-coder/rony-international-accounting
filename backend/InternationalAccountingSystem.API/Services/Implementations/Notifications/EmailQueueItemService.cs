using AutoMapper;
using InternationalAccountingSystem.API.Entities.Notifications;
using InternationalAccountingSystem.API.Dtos.Notifications;
using InternationalAccountingSystem.API.Repositories.Interfaces.Notifications;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Notifications;

namespace InternationalAccountingSystem.API.Services.Implementations.Notifications
{
    public class EmailQueueItemService : GenericService<EmailQueueItem, EmailQueueItemDto>, IEmailQueueItemService
    {
        public EmailQueueItemService(IEmailQueueItemRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
