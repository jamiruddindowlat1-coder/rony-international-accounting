using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Inventory;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Inventory;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Inventory
{
    public class StockLevelRepository : GenericRepository<StockLevel>, IStockLevelRepository
    {
        public StockLevelRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
