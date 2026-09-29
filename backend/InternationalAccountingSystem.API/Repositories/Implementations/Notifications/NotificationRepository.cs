using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Notifications;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Notifications;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Notifications
{
    public class NotificationRepository : GenericRepository<Notification>, INotificationRepository
    {
        public NotificationRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
