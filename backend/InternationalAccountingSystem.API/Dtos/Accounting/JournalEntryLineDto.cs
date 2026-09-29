using System;

namespace InternationalAccountingSystem.API.Dtos.Accounting
{
    public class JournalEntryLineDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long JournalEntryId { get; set; }
        public int LineNumber { get; set; }
        public long AccountId { get; set; }
        public long? CostCenterId { get; set; }
        public long? ProjectId { get; set; }
        public long? DepartmentId { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal BaseCurrencyDebit { get; set; }
        public decimal BaseCurrencyCredit { get; set; }
        public string Description { get; set; }
        public string PartyType { get; set; }
        public long? PartyId { get; set; }
        public long? TaxCodeId { get; set; }
        public string ReconciliationStatus { get; set; }
    }
}
