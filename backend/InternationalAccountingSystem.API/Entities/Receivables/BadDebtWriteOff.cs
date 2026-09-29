using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Receivables
{
    public class BadDebtWriteOff : BaseEntity
    {
        public long CustomerId { get; set; }
        public long InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public long? ApprovedBy { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
