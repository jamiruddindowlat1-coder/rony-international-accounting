using InternationalAccountingSystem.API.Entities.Receivables;
using InternationalAccountingSystem.API.Dtos.Receivables;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Receivables
{
    public interface ICustomerBankAccountService : IGenericService<CustomerBankAccount, CustomerBankAccountDto>
    {
    }
}
