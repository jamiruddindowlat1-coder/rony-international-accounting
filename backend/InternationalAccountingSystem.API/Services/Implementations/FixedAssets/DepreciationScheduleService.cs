using AutoMapper;
using InternationalAccountingSystem.API.Entities.FixedAssets;
using InternationalAccountingSystem.API.Dtos.FixedAssets;
using InternationalAccountingSystem.API.Repositories.Interfaces.FixedAssets;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.FixedAssets;

namespace InternationalAccountingSystem.API.Services.Implementations.FixedAssets
{
    public class DepreciationScheduleService : GenericService<DepreciationSchedule, DepreciationScheduleDto>, IDepreciationScheduleService
    {
        public DepreciationScheduleService(IDepreciationScheduleRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
