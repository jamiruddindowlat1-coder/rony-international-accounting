using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Inventory;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Inventory;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Inventory
{
    public class ItemCategoryRepository : GenericRepository<ItemCategory>, IItemCategoryRepository
    {
        public ItemCategoryRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
