using System;

namespace InternationalAccountingSystem.API.Dtos.Reporting
{
    public class FinancialStatementLineAccountDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long StatementLineId { get; set; }
        public long? AccountId { get; set; }
        public long? AccountGroupId { get; set; }
        public short SignMultiplier { get; set; }
    }
}
