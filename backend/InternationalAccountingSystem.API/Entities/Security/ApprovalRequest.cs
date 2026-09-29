using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Security
{
    public class ApprovalRequest : BaseEntity
    {
        public string EntityType { get; set; }
        public long EntityId { get; set; }
        public long WorkflowId { get; set; }
        public byte CurrentStepOrder { get; set; }
        public string Status { get; set; }
        public long RequestedBy { get; set; }
        public DateTime RequestedAt { get; set; }
    }
}
