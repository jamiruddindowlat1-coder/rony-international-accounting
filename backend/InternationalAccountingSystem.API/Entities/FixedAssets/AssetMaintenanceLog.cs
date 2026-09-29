using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.FixedAssets
{
    public class AssetMaintenanceLog : BaseEntity
    {
        public long AssetId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public long? VendorId { get; set; }
    }
}
