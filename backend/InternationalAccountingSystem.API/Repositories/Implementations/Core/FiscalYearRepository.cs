using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Core;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Core;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Core
{
    public class FiscalYearRepository : GenericRepository<FiscalYear>, IFiscalYearRepository
    {
        public FiscalYearRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
