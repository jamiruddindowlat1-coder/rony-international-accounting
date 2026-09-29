using System;

namespace InternationalAccountingSystem.API.Dtos.Payables
{
    public class PurchaseOrderLineDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long PurchaseOrderId { get; set; }
        public long? ItemId { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public long? TaxCodeId { get; set; }
        public long? AccountId { get; set; }
    }
}
