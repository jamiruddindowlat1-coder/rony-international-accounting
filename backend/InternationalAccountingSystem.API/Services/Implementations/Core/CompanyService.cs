using AutoMapper;
using InternationalAccountingSystem.API.Entities.Core;
using InternationalAccountingSystem.API.Dtos.Core;
using InternationalAccountingSystem.API.Repositories.Interfaces.Core;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Core;

namespace InternationalAccountingSystem.API.Services.Implementations.Core
{
    public class CompanyService : GenericService<Company, CompanyDto>, ICompanyService
    {
        public CompanyService(ICompanyRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
