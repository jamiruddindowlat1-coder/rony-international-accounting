using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Payroll;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Payroll;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Payroll
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
