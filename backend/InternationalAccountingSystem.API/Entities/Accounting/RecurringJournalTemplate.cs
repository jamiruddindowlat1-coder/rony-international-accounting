using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Accounting
{
    public class RecurringJournalTemplate : BaseEntity
    {
        public string Name { get; set; }
        public string Frequency { get; set; }
        public DateTime NextRunDate { get; set; }
        public string TemplateLinesJson { get; set; }
        public bool IsActive { get; set; }
    }
}
