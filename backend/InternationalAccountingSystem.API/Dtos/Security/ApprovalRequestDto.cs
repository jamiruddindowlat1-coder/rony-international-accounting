using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class ApprovalRequestDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string EntityType { get; set; }
        public long EntityId { get; set; }
        public long WorkflowId { get; set; }
        public byte CurrentStepOrder { get; set; }
        public string Status { get; set; }
        public long RequestedBy { get; set; }
        public DateTime RequestedAt { get; set; }
    }
}
