using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Inventory
{
    public class StockTransaction : BaseEntity
    {
        public long ItemId { get; set; }
        public long WarehouseId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public string SourceDocumentType { get; set; }
        public long? SourceDocumentId { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
