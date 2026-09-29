using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Accounting;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Accounting;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Accounting
{
    public class ChartOfAccountRepository : GenericRepository<ChartOfAccount>, IChartOfAccountRepository
    {
        public ChartOfAccountRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
