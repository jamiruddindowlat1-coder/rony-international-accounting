using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payables
{
    public class VendorCreditNote : BaseEntity
    {
        public long VendorId { get; set; }
        public string CreditNoteNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
