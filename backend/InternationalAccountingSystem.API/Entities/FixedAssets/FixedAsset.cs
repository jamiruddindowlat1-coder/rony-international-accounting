using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.FixedAssets
{
    public class FixedAsset : BaseEntity
    {
        public string AssetCode { get; set; }
        public string Name { get; set; }
        public long CategoryId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PurchaseCost { get; set; }
        public decimal SalvageValue { get; set; }
        public int UsefulLifeMonths { get; set; }
        public string DepreciationMethod { get; set; }
        public string Location { get; set; }
        public long? CustodianEmployeeId { get; set; }
        public string Status { get; set; }
        public decimal AccumulatedDepreciation { get; set; }
        public decimal NetBookValue { get; set; }
    }
}
