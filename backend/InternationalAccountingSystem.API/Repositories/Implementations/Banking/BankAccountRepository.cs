using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Banking;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Banking;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Banking
{
    public class BankAccountRepository : GenericRepository<BankAccount>, IBankAccountRepository
    {
        public BankAccountRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
