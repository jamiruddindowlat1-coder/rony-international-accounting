using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Payables;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Payables;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Payables
{
    public class WithholdingTaxEntryRepository : GenericRepository<WithholdingTaxEntry>, IWithholdingTaxEntryRepository
    {
        public WithholdingTaxEntryRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
