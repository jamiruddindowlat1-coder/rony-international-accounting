using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Notifications
{
    public class Notification : BaseEntity
    {
        public long UserId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string LinkUrl { get; set; }
        public bool IsRead { get; set; }
    }
}
