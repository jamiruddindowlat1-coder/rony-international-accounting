using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payables
{
    public class WithholdingTaxEntry : BaseEntity
    {
        public long VendorId { get; set; }
        public long SourceDocumentId { get; set; }
        public long TaxCodeId { get; set; }
        public decimal Amount { get; set; }
        public string CertificateNumber { get; set; }
    }
}
