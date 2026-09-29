using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Inventory
{
    public class Item : BaseEntity
    {
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
