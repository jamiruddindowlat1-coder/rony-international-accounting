using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Tax;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Tax;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Tax
{
    public class TaxTypeRepository : GenericRepository<TaxType>, ITaxTypeRepository
    {
        public TaxTypeRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
