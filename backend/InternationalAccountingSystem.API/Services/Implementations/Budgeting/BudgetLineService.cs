using AutoMapper;
using InternationalAccountingSystem.API.Entities.Budgeting;
using InternationalAccountingSystem.API.Dtos.Budgeting;
using InternationalAccountingSystem.API.Repositories.Interfaces.Budgeting;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Budgeting;

namespace InternationalAccountingSystem.API.Services.Implementations.Budgeting
{
    public class BudgetLineService : GenericService<BudgetLine, BudgetLineDto>, IBudgetLineService
    {
        public BudgetLineService(IBudgetLineRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
