using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Reporting;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Reporting;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Reporting
{
    public class ConsolidationMappingRepository : GenericRepository<ConsolidationMapping>, IConsolidationMappingRepository
    {
        public ConsolidationMappingRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
