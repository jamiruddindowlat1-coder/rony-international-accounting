using InternationalAccountingSystem.API.Entities.Payroll;
using InternationalAccountingSystem.API.Dtos.Payroll;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Payroll
{
    public interface IEmployeeLoanService : IGenericService<EmployeeLoan, EmployeeLoanDto>
    {
    }
}
