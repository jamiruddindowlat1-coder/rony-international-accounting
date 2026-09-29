using InternationalAccountingSystem.API.Entities.Reporting;
using InternationalAccountingSystem.API.Dtos.Reporting;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Reporting
{
    public interface IConsolidationMappingService : IGenericService<ConsolidationMapping, ConsolidationMappingDto>
    {
    }
}
