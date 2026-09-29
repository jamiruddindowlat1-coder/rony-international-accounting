using InternationalAccountingSystem.API.Entities.Banking;
using InternationalAccountingSystem.API.Dtos.Banking;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Banking
{
    public interface IBankTransactionService : IGenericService<BankTransaction, BankTransactionDto>
    {
    }
}
