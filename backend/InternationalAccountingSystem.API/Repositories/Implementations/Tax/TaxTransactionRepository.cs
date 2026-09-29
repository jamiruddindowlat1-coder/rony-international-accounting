using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Tax;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Tax;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Tax
{
    public class TaxTransactionRepository : GenericRepository<TaxTransaction>, ITaxTransactionRepository
    {
        public TaxTransactionRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
