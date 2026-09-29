using System;

namespace InternationalAccountingSystem.API.Dtos.Budgeting
{
    public class BudgetVersionDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long FiscalYearId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public long? ApprovedBy { get; set; }
        public DateTime? ApprovedAt { get; set; }
    }
}
