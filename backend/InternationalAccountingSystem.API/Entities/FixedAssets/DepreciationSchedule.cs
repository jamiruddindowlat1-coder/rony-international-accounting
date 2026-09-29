using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.FixedAssets
{
    public class DepreciationSchedule : BaseEntity
    {
        public long AssetId { get; set; }
        public DateTime PeriodDate { get; set; }
        public decimal DepreciationAmount { get; set; }
        public decimal AccumulatedDepreciation { get; set; }
        public decimal NetBookValue { get; set; }
        public long? JournalEntryId { get; set; }
        public bool IsPosted { get; set; }
    }
}
