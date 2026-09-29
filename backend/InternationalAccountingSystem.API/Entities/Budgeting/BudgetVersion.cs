using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Budgeting
{
    public class BudgetVersion : BaseEntity
    {
        public long FiscalYearId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public long? ApprovedBy { get; set; }
        public DateTime? ApprovedAt { get; set; }
    }
}
