using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Security
{
    public class LoginHistory : BaseGlobalEntity
    {
        public long? UserId { get; set; }
        public string AttemptedUsername { get; set; }
        public DateTime LoginAt { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public bool Success { get; set; }
        public string FailureReason { get; set; }
    }
}
