using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Banking
{
    public class BankReconciliation : BaseEntity
    {
        public long BankAccountId { get; set; }
        public DateTime ReconciliationDate { get; set; }
        public decimal StatementBalance { get; set; }
        public decimal BookBalance { get; set; }
        public string Status { get; set; }
        public long? ReconciledBy { get; set; }
    }
}
