using System;

namespace InternationalAccountingSystem.API.Dtos.Inventory
{
    public class StockValuationLayerDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long ItemId { get; set; }
        public long WarehouseId { get; set; }
        public DateTime ReceiptDate { get; set; }
        public decimal QuantityRemaining { get; set; }
        public decimal UnitCost { get; set; }
    }
}
