using AutoMapper;
using InternationalAccountingSystem.API.Entities.Reporting;
using InternationalAccountingSystem.API.Dtos.Reporting;
using InternationalAccountingSystem.API.Repositories.Interfaces.Reporting;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Reporting;

namespace InternationalAccountingSystem.API.Services.Implementations.Reporting
{
    public class FinancialStatementTemplateService : GenericService<FinancialStatementTemplate, FinancialStatementTemplateDto>, IFinancialStatementTemplateService
    {
        public FinancialStatementTemplateService(IFinancialStatementTemplateRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
