using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payroll
{
    public class PayrollRun : BaseEntity
    {
        public long AccountingPeriodId { get; set; }
        public DateTime RunDate { get; set; }
        public string Status { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
