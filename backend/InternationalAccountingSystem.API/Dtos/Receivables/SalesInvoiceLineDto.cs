using System;

namespace InternationalAccountingSystem.API.Dtos.Receivables
{
    public class SalesInvoiceLineDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long InvoiceId { get; set; }
        public long? ItemId { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public long? TaxCodeId { get; set; }
        public long AccountId { get; set; }
        public long? CostCenterId { get; set; }
        public long? ProjectId { get; set; }
        public decimal LineTotal { get; set; }
    }
}
