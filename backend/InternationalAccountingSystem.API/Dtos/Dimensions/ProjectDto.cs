using System;

namespace InternationalAccountingSystem.API.Dtos.Dimensions
{
    public class ProjectDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long? CustomerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? BudgetAmount { get; set; }
        public string Status { get; set; }
    }
}
