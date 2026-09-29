using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.FixedAssets
{
    public class AssetCategory : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultUsefulLifeMonths { get; set; }
        public string DefaultDepreciationMethod { get; set; }
        public long AssetAccountId { get; set; }
        public long DepreciationExpenseAccountId { get; set; }
        public long AccumulatedDepreciationAccountId { get; set; }
    }
}
