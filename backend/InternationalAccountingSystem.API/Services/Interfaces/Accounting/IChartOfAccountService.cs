using InternationalAccountingSystem.API.Entities.Accounting;
using InternationalAccountingSystem.API.Dtos.Accounting;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Accounting
{
    public interface IChartOfAccountService : IGenericService<ChartOfAccount, ChartOfAccountDto>
    {
    }
}
