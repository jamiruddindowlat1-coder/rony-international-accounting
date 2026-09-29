using AutoMapper;
using InternationalAccountingSystem.API.Entities.Payroll;
using InternationalAccountingSystem.API.Dtos.Payroll;
using InternationalAccountingSystem.API.Repositories.Interfaces.Payroll;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Payroll;

namespace InternationalAccountingSystem.API.Services.Implementations.Payroll
{
    public class EmployeeLoanService : GenericService<EmployeeLoan, EmployeeLoanDto>, IEmployeeLoanService
    {
        public EmployeeLoanService(IEmployeeLoanRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
