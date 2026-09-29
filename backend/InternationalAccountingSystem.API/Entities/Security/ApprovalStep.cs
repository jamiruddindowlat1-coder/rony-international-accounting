using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Security
{
    public class ApprovalStep : BaseEntity
    {
        public long WorkflowId { get; set; }
        public byte StepOrder { get; set; }
        public long? ApproverRoleId { get; set; }
        public bool IsMandatory { get; set; }
    }
}
