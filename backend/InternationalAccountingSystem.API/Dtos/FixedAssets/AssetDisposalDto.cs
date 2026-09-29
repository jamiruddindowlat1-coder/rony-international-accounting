using System;

namespace InternationalAccountingSystem.API.Dtos.FixedAssets
{
    public class AssetDisposalDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long AssetId { get; set; }
        public DateTime DisposalDate { get; set; }
        public decimal DisposalProceeds { get; set; }
        public decimal NetBookValueAtDisposal { get; set; }
        public decimal GainLossAmount { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
