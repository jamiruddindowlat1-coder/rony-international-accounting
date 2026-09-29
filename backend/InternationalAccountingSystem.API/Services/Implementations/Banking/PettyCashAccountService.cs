using AutoMapper;
using InternationalAccountingSystem.API.Entities.Banking;
using InternationalAccountingSystem.API.Dtos.Banking;
using InternationalAccountingSystem.API.Repositories.Interfaces.Banking;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Banking;

namespace InternationalAccountingSystem.API.Services.Implementations.Banking
{
    public class PettyCashAccountService : GenericService<PettyCashAccount, PettyCashAccountDto>, IPettyCashAccountService
    {
        public PettyCashAccountService(IPettyCashAccountRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
