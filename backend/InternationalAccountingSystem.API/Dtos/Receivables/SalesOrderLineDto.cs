using System;

namespace InternationalAccountingSystem.API.Dtos.Receivables
{
    public class SalesOrderLineDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long SalesOrderId { get; set; }
        public long? ItemId { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public long? TaxCodeId { get; set; }
    }
}
