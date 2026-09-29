using AutoMapper;
using InternationalAccountingSystem.API.Entities.Reporting;
using InternationalAccountingSystem.API.Dtos.Reporting;
using InternationalAccountingSystem.API.Repositories.Interfaces.Reporting;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Reporting;

namespace InternationalAccountingSystem.API.Services.Implementations.Reporting
{
    public class ConsolidationMappingService : GenericService<ConsolidationMapping, ConsolidationMappingDto>, IConsolidationMappingService
    {
        public ConsolidationMappingService(IConsolidationMappingRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
