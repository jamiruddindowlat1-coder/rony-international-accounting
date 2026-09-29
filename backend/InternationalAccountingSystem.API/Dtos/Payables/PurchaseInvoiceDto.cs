using System;

namespace InternationalAccountingSystem.API.Dtos.Payables
{
    public class PurchaseInvoiceDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long BranchId { get; set; }
        public long VendorId { get; set; }
        public long? PurchaseOrderId { get; set; }
        public string InvoiceNumber { get; set; }
        public string VendorInvoiceReference { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRateToBase { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
