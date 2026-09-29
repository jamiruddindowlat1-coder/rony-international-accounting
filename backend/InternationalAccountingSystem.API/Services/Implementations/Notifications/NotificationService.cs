using AutoMapper;
using InternationalAccountingSystem.API.Entities.Notifications;
using InternationalAccountingSystem.API.Dtos.Notifications;
using InternationalAccountingSystem.API.Repositories.Interfaces.Notifications;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Notifications;

namespace InternationalAccountingSystem.API.Services.Implementations.Notifications
{
    public class NotificationService : GenericService<Notification, NotificationDto>, INotificationService
    {
        public NotificationService(INotificationRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
