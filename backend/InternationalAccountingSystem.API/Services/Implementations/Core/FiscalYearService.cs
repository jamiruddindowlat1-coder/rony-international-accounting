using AutoMapper;
using InternationalAccountingSystem.API.Entities.Core;
using InternationalAccountingSystem.API.Dtos.Core;
using InternationalAccountingSystem.API.Repositories.Interfaces.Core;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Core;

namespace InternationalAccountingSystem.API.Services.Implementations.Core
{
    public class FiscalYearService : GenericService<FiscalYear, FiscalYearDto>, IFiscalYearService
    {
        public FiscalYearService(IFiscalYearRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
