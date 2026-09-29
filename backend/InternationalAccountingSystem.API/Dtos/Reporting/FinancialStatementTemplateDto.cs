using System;

namespace InternationalAccountingSystem.API.Dtos.Reporting
{
    public class FinancialStatementTemplateDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsDefault { get; set; }
    }
}
