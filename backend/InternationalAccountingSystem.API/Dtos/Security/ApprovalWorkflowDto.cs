using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class ApprovalWorkflowDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string EntityType { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
    }
}
