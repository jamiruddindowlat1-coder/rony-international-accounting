using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Accounting;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Accounting;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Accounting
{
    public class AccountTypeRepository : GenericRepository<AccountType>, IAccountTypeRepository
    {
        public AccountTypeRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
