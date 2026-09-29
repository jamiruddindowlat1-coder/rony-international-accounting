using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Banking;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Banking;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Banking
{
    public class PettyCashAccountRepository : GenericRepository<PettyCashAccount>, IPettyCashAccountRepository
    {
        public PettyCashAccountRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
