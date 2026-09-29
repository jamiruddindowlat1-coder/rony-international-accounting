using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.FixedAssets
{
    public class AssetDisposal : BaseEntity
    {
        public long AssetId { get; set; }
        public DateTime DisposalDate { get; set; }
        public decimal DisposalProceeds { get; set; }
        public decimal NetBookValueAtDisposal { get; set; }
        public decimal GainLossAmount { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
