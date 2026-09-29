using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Accounting;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Accounting;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Accounting
{
    public class RecurringJournalTemplateRepository : GenericRepository<RecurringJournalTemplate>, IRecurringJournalTemplateRepository
    {
        public RecurringJournalTemplateRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
