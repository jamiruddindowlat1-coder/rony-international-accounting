using System;

namespace InternationalAccountingSystem.API.Dtos.Budgeting
{
    public class BudgetLineDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long BudgetVersionId { get; set; }
        public long AccountId { get; set; }
        public long? CostCenterId { get; set; }
        public long? ProjectId { get; set; }
        public long? DepartmentId { get; set; }
        public long AccountingPeriodId { get; set; }
        public decimal BudgetedAmount { get; set; }
    }
}
