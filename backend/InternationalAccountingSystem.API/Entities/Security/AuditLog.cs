using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Security
{
    public class AuditLog : BaseEntity
    {
        public long? UserId { get; set; }
        public string EntityName { get; set; }
        public long EntityId { get; set; }
        public string Action { get; set; }
        public string OldValuesJson { get; set; }
        public string NewValuesJson { get; set; }
        public DateTime Timestamp { get; set; }
        public string IpAddress { get; set; }
    }
}
