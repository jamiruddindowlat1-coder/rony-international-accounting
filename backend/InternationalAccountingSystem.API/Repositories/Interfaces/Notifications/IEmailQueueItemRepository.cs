using InternationalAccountingSystem.API.Entities.Notifications;
using InternationalAccountingSystem.API.Repositories.Generic;

namespace InternationalAccountingSystem.API.Repositories.Interfaces.Notifications
{
    public interface IEmailQueueItemRepository : IGenericRepository<EmailQueueItem>
    {
    }
}
