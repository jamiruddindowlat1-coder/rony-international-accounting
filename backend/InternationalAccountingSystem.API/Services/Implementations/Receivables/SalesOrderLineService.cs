using AutoMapper;
using InternationalAccountingSystem.API.Entities.Receivables;
using InternationalAccountingSystem.API.Dtos.Receivables;
using InternationalAccountingSystem.API.Repositories.Interfaces.Receivables;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Receivables;

namespace InternationalAccountingSystem.API.Services.Implementations.Receivables
{
    public class SalesOrderLineService : GenericService<SalesOrderLine, SalesOrderLineDto>, ISalesOrderLineService
    {
        public SalesOrderLineService(ISalesOrderLineRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
