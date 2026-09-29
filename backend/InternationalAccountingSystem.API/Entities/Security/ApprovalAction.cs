using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Security
{
    public class ApprovalAction : BaseEntity
    {
        public long ApprovalRequestId { get; set; }
        public byte StepOrder { get; set; }
        public long ActionBy { get; set; }
        public string Action { get; set; }
        public string Comments { get; set; }
        public DateTime ActionAt { get; set; }
    }
}
