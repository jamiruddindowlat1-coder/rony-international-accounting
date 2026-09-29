using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class ApprovalStepDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long WorkflowId { get; set; }
        public byte StepOrder { get; set; }
        public long? ApproverRoleId { get; set; }
        public bool IsMandatory { get; set; }
    }
}
