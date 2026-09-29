using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Notifications
{
    public class SmsQueueItem : BaseGlobalEntity
    {
        public string ToPhoneNumber { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public int RetryCount { get; set; }
        public string LastError { get; set; }
        public DateTime? SentAt { get; set; }
    }
}
