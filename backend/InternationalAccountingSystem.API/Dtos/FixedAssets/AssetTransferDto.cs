using System;

namespace InternationalAccountingSystem.API.Dtos.FixedAssets
{
    public class AssetTransferDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long AssetId { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime TransferDate { get; set; }
        public long? ApprovedBy { get; set; }
    }
}
