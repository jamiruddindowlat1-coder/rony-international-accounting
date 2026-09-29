using System;

namespace InternationalAccountingSystem.API.Dtos.Payables
{
    public class WithholdingTaxEntryDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long VendorId { get; set; }
        public long SourceDocumentId { get; set; }
        public long TaxCodeId { get; set; }
        public decimal Amount { get; set; }
        public string CertificateNumber { get; set; }
    }
}
