using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Core;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Core;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Core
{
    public class CurrencyRepository : GenericRepository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
