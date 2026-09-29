using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Receivables
{
    public class SalesInvoice : BaseEntity
    {
        public long BranchId { get; set; }
        public long CustomerId { get; set; }
        public long? SalesOrderId { get; set; }
        public string InvoiceNumber { get; set; }
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
