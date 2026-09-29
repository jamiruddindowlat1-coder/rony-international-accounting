using System;

namespace InternationalAccountingSystem.API.Dtos.Inventory
{
    public class StockLevelDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long ItemId { get; set; }
        public long WarehouseId { get; set; }
        public decimal QuantityOnHand { get; set; }
        public decimal AverageCost { get; set; }
    }
}
