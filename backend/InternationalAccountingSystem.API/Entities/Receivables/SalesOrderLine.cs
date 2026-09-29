using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Receivables
{
    public class SalesOrderLine : BaseEntity
    {
        public long SalesOrderId { get; set; }
        public long? ItemId { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public long? TaxCodeId { get; set; }
    }
}
