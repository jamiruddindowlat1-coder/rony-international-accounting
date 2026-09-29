using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class ApprovalActionDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long ApprovalRequestId { get; set; }
        public byte StepOrder { get; set; }
        public long ActionBy { get; set; }
        public string Action { get; set; }
        public string Comments { get; set; }
        public DateTime ActionAt { get; set; }
    }
}
