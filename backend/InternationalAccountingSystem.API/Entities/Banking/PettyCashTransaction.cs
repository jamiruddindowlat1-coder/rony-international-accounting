using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Banking
{
    public class PettyCashTransaction : BaseEntity
    {
        public long PettyCashAccountId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public long? JournalEntryId { get; set; }
    }
}
