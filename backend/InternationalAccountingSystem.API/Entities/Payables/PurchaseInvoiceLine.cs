using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payables
{
    public class PurchaseInvoiceLine : BaseEntity
    {
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
