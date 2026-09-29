using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Receivables
{
    public class CustomerCreditNote : BaseEntity
    {
        public long CustomerId { get; set; }
        public string CreditNoteNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
