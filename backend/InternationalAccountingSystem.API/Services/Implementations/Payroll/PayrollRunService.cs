using AutoMapper;
using InternationalAccountingSystem.API.Entities.Payroll;
using InternationalAccountingSystem.API.Dtos.Payroll;
using InternationalAccountingSystem.API.Repositories.Interfaces.Payroll;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Payroll;

namespace InternationalAccountingSystem.API.Services.Implementations.Payroll
{
    public class PayrollRunService : GenericService<PayrollRun, PayrollRunDto>, IPayrollRunService
    {
        public PayrollRunService(IPayrollRunRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
