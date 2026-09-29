using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Tax;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Tax;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Tax
{
    public class TaxJurisdictionRepository : GenericRepository<TaxJurisdiction>, ITaxJurisdictionRepository
    {
        public TaxJurisdictionRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
