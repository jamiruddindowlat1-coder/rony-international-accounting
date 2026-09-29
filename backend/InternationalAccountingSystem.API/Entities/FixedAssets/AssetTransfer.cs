using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.FixedAssets
{
    public class AssetTransfer : BaseEntity
    {
        public long AssetId { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime TransferDate { get; set; }
        public long? ApprovedBy { get; set; }
    }
}
