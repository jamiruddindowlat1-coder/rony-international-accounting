using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Budgeting;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Budgeting;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Budgeting
{
    public class BudgetLineRepository : GenericRepository<BudgetLine>, IBudgetLineRepository
    {
        public BudgetLineRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
