using System;

namespace InternationalAccountingSystem.API.Dtos.Banking
{
    public class BankReconciliationDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long BankAccountId { get; set; }
        public DateTime ReconciliationDate { get; set; }
        public decimal StatementBalance { get; set; }
        public decimal BookBalance { get; set; }
        public string Status { get; set; }
        public long? ReconciledBy { get; set; }
    }
}
