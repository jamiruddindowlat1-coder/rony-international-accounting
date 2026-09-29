using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Budgeting
{
    public class BudgetLine : BaseEntity
    {
        public long BudgetVersionId { get; set; }
        public long AccountId { get; set; }
        public long? CostCenterId { get; set; }
        public long? ProjectId { get; set; }
        public long? DepartmentId { get; set; }
        public long AccountingPeriodId { get; set; }
        public decimal BudgetedAmount { get; set; }
    }
}
