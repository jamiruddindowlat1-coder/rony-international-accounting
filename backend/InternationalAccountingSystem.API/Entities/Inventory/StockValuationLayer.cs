using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Inventory
{
    public class StockValuationLayer : BaseEntity
    {
        public long ItemId { get; set; }
        public long WarehouseId { get; set; }
        public DateTime ReceiptDate { get; set; }
        public decimal QuantityRemaining { get; set; }
        public decimal UnitCost { get; set; }
    }
}
