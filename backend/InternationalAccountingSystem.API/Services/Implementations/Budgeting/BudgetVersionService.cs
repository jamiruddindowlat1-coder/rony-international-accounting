using AutoMapper;
using InternationalAccountingSystem.API.Entities.Budgeting;
using InternationalAccountingSystem.API.Dtos.Budgeting;
using InternationalAccountingSystem.API.Repositories.Interfaces.Budgeting;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Budgeting;

namespace InternationalAccountingSystem.API.Services.Implementations.Budgeting
{
    public class BudgetVersionService : GenericService<BudgetVersion, BudgetVersionDto>, IBudgetVersionService
    {
        public BudgetVersionService(IBudgetVersionRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
