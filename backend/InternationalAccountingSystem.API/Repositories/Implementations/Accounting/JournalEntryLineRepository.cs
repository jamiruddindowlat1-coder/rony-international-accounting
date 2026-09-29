using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Accounting;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Accounting;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Accounting
{
    public class JournalEntryLineRepository : GenericRepository<JournalEntryLine>, IJournalEntryLineRepository
    {
        public JournalEntryLineRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
