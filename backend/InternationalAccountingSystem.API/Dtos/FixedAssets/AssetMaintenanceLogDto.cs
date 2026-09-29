using System;

namespace InternationalAccountingSystem.API.Dtos.FixedAssets
{
    public class AssetMaintenanceLogDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long AssetId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public long? VendorId { get; set; }
    }
}
