using AutoMapper;
using InternationalAccountingSystem.API.Entities.Payroll;
using InternationalAccountingSystem.API.Dtos.Payroll;
using InternationalAccountingSystem.API.Repositories.Interfaces.Payroll;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Payroll;

namespace InternationalAccountingSystem.API.Services.Implementations.Payroll
{
    public class EmployeeService : GenericService<Employee, EmployeeDto>, IEmployeeService
    {
        public EmployeeService(IEmployeeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
