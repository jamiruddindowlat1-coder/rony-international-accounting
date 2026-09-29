using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class LoginHistoryDto
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string AttemptedUsername { get; set; }
        public DateTime LoginAt { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public bool Success { get; set; }
        public string FailureReason { get; set; }
    }
}
