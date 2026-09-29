using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Notifications;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Notifications;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Notifications
{
    public class EmailQueueItemRepository : GenericRepository<EmailQueueItem>, IEmailQueueItemRepository
    {
        public EmailQueueItemRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
