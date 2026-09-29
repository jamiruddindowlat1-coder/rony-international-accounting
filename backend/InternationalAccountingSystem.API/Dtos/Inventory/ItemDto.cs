using System;

namespace InternationalAccountingSystem.API.Dtos.Inventory
{
    public class ItemDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string ItemCode { get; set; }
        public string Name { get; set; }
        public string ItemType { get; set; }
        public string UnitOfMeasure { get; set; }
        public long? CategoryId { get; set; }
        public long? SalesAccountId { get; set; }
        public long? PurchaseAccountId { get; set; }
        public long? InventoryAssetAccountId { get; set; }
        public string CostingMethod { get; set; }
        public decimal? StandardCost { get; set; }
        public bool IsActive { get; set; }
    }
}
