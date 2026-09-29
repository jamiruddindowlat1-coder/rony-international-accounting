using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Inventory
{
    public class StockLevel : BaseEntity
    {
        public long ItemId { get; set; }
        public long WarehouseId { get; set; }
        public decimal QuantityOnHand { get; set; }
        public decimal AverageCost { get; set; }
    }
}
