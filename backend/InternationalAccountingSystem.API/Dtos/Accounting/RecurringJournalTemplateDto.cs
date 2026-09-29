using System;

namespace InternationalAccountingSystem.API.Dtos.Accounting
{
    public class RecurringJournalTemplateDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string Name { get; set; }
        public string Frequency { get; set; }
        public DateTime NextRunDate { get; set; }
        public string TemplateLinesJson { get; set; }
        public bool IsActive { get; set; }
    }
}
