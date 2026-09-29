using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Notifications
{
    public class EmailQueueItem : BaseGlobalEntity
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Status { get; set; }
        public int RetryCount { get; set; }
        public string LastError { get; set; }
        public DateTime? SentAt { get; set; }
    }
}
