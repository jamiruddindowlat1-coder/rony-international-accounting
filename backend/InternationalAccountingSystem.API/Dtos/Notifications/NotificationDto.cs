using System;

namespace InternationalAccountingSystem.API.Dtos.Notifications
{
    public class NotificationDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long UserId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string LinkUrl { get; set; }
        public bool IsRead { get; set; }
    }
}
