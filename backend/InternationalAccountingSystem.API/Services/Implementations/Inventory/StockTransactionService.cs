using AutoMapper;
using InternationalAccountingSystem.API.Entities.Inventory;
using InternationalAccountingSystem.API.Dtos.Inventory;
using InternationalAccountingSystem.API.Repositories.Interfaces.Inventory;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Inventory;

namespace InternationalAccountingSystem.API.Services.Implementations.Inventory
{
    public class StockTransactionService : GenericService<StockTransaction, StockTransactionDto>, IStockTransactionService
    {
        public StockTransactionService(IStockTransactionRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
