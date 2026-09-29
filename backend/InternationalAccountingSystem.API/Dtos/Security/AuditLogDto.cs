using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class AuditLogDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
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
