using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Notifications;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Notifications;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Notifications
{
    public class SmsQueueItemRepository : GenericRepository<SmsQueueItem>, ISmsQueueItemRepository
    {
        public SmsQueueItemRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
