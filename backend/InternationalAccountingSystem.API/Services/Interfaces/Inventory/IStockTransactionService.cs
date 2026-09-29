using InternationalAccountingSystem.API.Entities.Inventory;
using InternationalAccountingSystem.API.Dtos.Inventory;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Inventory
{
    public interface IStockTransactionService : IGenericService<StockTransaction, StockTransactionDto>
    {
    }
}
