using System;

namespace InternationalAccountingSystem.API.Dtos.Reporting
{
    public class ConsolidationMappingDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long SubsidiaryCompanyId { get; set; }
        public long ParentCompanyId { get; set; }
        public decimal OwnershipPercentage { get; set; }
        public long? EliminationAccountId { get; set; }
    }
}
