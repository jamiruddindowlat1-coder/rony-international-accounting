using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Tax
{
    public class TaxTransaction : BaseEntity
    {
        public string SourceDocumentType { get; set; }
        public long SourceDocumentId { get; set; }
        public long TaxCodeId { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
