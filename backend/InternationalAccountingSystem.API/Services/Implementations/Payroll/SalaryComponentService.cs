using AutoMapper;
using InternationalAccountingSystem.API.Entities.Payroll;
using InternationalAccountingSystem.API.Dtos.Payroll;
using InternationalAccountingSystem.API.Repositories.Interfaces.Payroll;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Payroll;

namespace InternationalAccountingSystem.API.Services.Implementations.Payroll
{
    public class SalaryComponentService : GenericService<SalaryComponent, SalaryComponentDto>, ISalaryComponentService
    {
        public SalaryComponentService(ISalaryComponentRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
