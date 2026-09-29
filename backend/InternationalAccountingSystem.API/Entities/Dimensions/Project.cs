using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Dimensions
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public long? CustomerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? BudgetAmount { get; set; }
        public string Status { get; set; }
    }
}
