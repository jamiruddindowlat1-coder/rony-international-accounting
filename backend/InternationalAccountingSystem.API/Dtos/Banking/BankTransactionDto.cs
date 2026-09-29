using System;

namespace InternationalAccountingSystem.API.Dtos.Banking
{
    public class BankTransactionDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long BankAccountId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? ValueDate { get; set; }
        public string Description { get; set; }
        public string ReferenceNumber { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public long? JournalEntryId { get; set; }
        public string ReconciliationStatus { get; set; }
        public long? ReconciledOnStatementId { get; set; }
    }
}
