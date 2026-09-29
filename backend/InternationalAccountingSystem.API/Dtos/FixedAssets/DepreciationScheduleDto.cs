using System;

namespace InternationalAccountingSystem.API.Dtos.FixedAssets
{
    public class DepreciationScheduleDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long AssetId { get; set; }
        public DateTime PeriodDate { get; set; }
        public decimal DepreciationAmount { get; set; }
        public decimal AccumulatedDepreciation { get; set; }
        public decimal NetBookValue { get; set; }
        public long? JournalEntryId { get; set; }
        public bool IsPosted { get; set; }
    }
}
