using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Banking;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Banking;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Banking
{
    public class BankStatementImportRepository : GenericRepository<BankStatementImport>, IBankStatementImportRepository
    {
        public BankStatementImportRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
