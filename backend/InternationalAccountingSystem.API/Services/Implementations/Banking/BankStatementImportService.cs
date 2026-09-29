using AutoMapper;
using InternationalAccountingSystem.API.Entities.Banking;
using InternationalAccountingSystem.API.Dtos.Banking;
using InternationalAccountingSystem.API.Repositories.Interfaces.Banking;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Banking;

namespace InternationalAccountingSystem.API.Services.Implementations.Banking
{
    public class BankStatementImportService : GenericService<BankStatementImport, BankStatementImportDto>, IBankStatementImportService
    {
        public BankStatementImportService(IBankStatementImportRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
