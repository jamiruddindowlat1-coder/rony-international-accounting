using InternationalAccountingSystem.API.Entities.Budgeting;
using InternationalAccountingSystem.API.Dtos.Budgeting;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Budgeting
{
    public interface IBudgetLineService : IGenericService<BudgetLine, BudgetLineDto>
    {
    }
}
