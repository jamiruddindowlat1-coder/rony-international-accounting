using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Reporting
{
    public class FinancialStatementTemplate : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsDefault { get; set; }
    }
}
