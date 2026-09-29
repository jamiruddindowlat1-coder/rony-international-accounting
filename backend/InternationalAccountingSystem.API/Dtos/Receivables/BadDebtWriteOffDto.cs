using System;

namespace InternationalAccountingSystem.API.Dtos.Receivables
{
    public class BadDebtWriteOffDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long CustomerId { get; set; }
        public long InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public long? ApprovedBy { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
