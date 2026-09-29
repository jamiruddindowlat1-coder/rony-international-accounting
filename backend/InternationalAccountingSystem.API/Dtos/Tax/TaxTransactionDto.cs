using System;

namespace InternationalAccountingSystem.API.Dtos.Tax
{
    public class TaxTransactionDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string SourceDocumentType { get; set; }
        public long SourceDocumentId { get; set; }
        public long TaxCodeId { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
