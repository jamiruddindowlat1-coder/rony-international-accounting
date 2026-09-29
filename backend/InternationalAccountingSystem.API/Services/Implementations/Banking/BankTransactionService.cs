using AutoMapper;
using InternationalAccountingSystem.API.Entities.Banking;
using InternationalAccountingSystem.API.Dtos.Banking;
using InternationalAccountingSystem.API.Repositories.Interfaces.Banking;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Banking;

namespace InternationalAccountingSystem.API.Services.Implementations.Banking
{
    public class BankTransactionService : GenericService<BankTransaction, BankTransactionDto>, IBankTransactionService
    {
        public BankTransactionService(IBankTransactionRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
