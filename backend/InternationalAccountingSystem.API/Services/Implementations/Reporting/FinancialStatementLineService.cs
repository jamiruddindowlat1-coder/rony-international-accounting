using AutoMapper;
using InternationalAccountingSystem.API.Entities.Reporting;
using InternationalAccountingSystem.API.Dtos.Reporting;
using InternationalAccountingSystem.API.Repositories.Interfaces.Reporting;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Reporting;

namespace InternationalAccountingSystem.API.Services.Implementations.Reporting
{
    public class FinancialStatementLineService : GenericService<FinancialStatementLine, FinancialStatementLineDto>, IFinancialStatementLineService
    {
        public FinancialStatementLineService(IFinancialStatementLineRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
