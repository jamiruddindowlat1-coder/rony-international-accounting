using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Inventory;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Inventory;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Inventory
{
    public class WarehouseRepository : GenericRepository<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
