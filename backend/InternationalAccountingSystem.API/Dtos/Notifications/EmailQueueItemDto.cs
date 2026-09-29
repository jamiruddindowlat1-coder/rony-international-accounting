using System;

namespace InternationalAccountingSystem.API.Dtos.Notifications
{
    public class EmailQueueItemDto
    {
        public long Id { get; set; }
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Status { get; set; }
        public int RetryCount { get; set; }
        public string LastError { get; set; }
        public DateTime? SentAt { get; set; }
    }
}
