using System;

namespace InternationalAccountingSystem.API.Dtos.Payables
{
    public class VendorCreditNoteDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long VendorId { get; set; }
        public string CreditNoteNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
