using AutoMapper;
using InternationalAccountingSystem.API.Entities.Core;
using InternationalAccountingSystem.API.Dtos.Core;
using InternationalAccountingSystem.API.Repositories.Interfaces.Core;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Core;

namespace InternationalAccountingSystem.API.Services.Implementations.Core
{
    public class NumberSequenceService : GenericService<NumberSequence, NumberSequenceDto>, INumberSequenceService
    {
        public NumberSequenceService(INumberSequenceRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
