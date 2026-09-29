using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Reporting
{
    public class ConsolidationMapping : BaseEntity
    {
        public long SubsidiaryCompanyId { get; set; }
        public long ParentCompanyId { get; set; }
        public decimal OwnershipPercentage { get; set; }
        public long? EliminationAccountId { get; set; }
    }
}
