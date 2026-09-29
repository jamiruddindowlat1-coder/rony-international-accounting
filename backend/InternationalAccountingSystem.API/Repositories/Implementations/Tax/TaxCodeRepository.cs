using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Tax;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Tax;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Tax
{
    public class TaxCodeRepository : GenericRepository<TaxCode>, ITaxCodeRepository
    {
        public TaxCodeRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
