using System;

namespace InternationalAccountingSystem.API.Dtos.Accounting
{
    public class JournalEntryDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long BranchId { get; set; }
        public long AccountingPeriodId { get; set; }
        public string VoucherNumber { get; set; }
        public DateTime VoucherDate { get; set; }
        public string VoucherType { get; set; }
        public string SourceModule { get; set; }
        public long? SourceDocumentId { get; set; }
        public string Reference { get; set; }
        public string Narration { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRateToBase { get; set; }
        public string Status { get; set; }
        public DateTime? PostedAt { get; set; }
        public long? PostedBy { get; set; }
        public long? ReversalOfEntryId { get; set; }
    }
}
