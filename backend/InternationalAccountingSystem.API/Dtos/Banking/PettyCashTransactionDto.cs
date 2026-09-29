using System;

namespace InternationalAccountingSystem.API.Dtos.Banking
{
    public class PettyCashTransactionDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long PettyCashAccountId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
