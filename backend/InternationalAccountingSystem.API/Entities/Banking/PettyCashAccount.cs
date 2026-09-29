using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Banking
{
    public class PettyCashAccount : BaseEntity
    {
        public string Name { get; set; }
        public long CustodianUserId { get; set; }
        public long GLAccountId { get; set; }
        public decimal ImprestLimit { get; set; }
    }
}
