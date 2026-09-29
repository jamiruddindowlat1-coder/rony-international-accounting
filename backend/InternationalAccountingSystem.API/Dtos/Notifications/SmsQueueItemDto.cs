using System;

namespace InternationalAccountingSystem.API.Dtos.Notifications
{
    public class SmsQueueItemDto
    {
        public long Id { get; set; }
        public string ToPhoneNumber { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public int RetryCount { get; set; }
        public string LastError { get; set; }
        public DateTime? SentAt { get; set; }
    }
}
