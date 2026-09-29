using System;

namespace InternationalAccountingSystem.API.Dtos.Core
{
    public class FiscalYearDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClosed { get; set; }
        public DateTime? ClosedAt { get; set; }
    }
}
