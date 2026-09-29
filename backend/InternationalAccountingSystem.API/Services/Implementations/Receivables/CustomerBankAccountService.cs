using AutoMapper;
using InternationalAccountingSystem.API.Entities.Receivables;
using InternationalAccountingSystem.API.Dtos.Receivables;
using InternationalAccountingSystem.API.Repositories.Interfaces.Receivables;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Receivables;

namespace InternationalAccountingSystem.API.Services.Implementations.Receivables
{
    public class CustomerBankAccountService : GenericService<CustomerBankAccount, CustomerBankAccountDto>, ICustomerBankAccountService
    {
        public CustomerBankAccountService(ICustomerBankAccountRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
