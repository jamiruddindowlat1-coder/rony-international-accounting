using System;

namespace InternationalAccountingSystem.API.Dtos.Payroll
{
    public class PayrollRunDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long AccountingPeriodId { get; set; }
        public DateTime RunDate { get; set; }
        public string Status { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
