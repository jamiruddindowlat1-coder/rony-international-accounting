using System;

namespace InternationalAccountingSystem.API.Dtos.FixedAssets
{
    public class AssetCategoryDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string Name { get; set; }
        public int DefaultUsefulLifeMonths { get; set; }
        public string DefaultDepreciationMethod { get; set; }
        public long AssetAccountId { get; set; }
        public long DepreciationExpenseAccountId { get; set; }
        public long AccumulatedDepreciationAccountId { get; set; }
    }
}
