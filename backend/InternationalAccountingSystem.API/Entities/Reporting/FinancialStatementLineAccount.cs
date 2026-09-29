using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Reporting
{
    public class FinancialStatementLineAccount : BaseEntity
    {
        public long StatementLineId { get; set; }
        public long? AccountId { get; set; }
        public long? AccountGroupId { get; set; }
        public short SignMultiplier { get; set; }
    }
}
