using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Payroll;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Payroll;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Payroll
{
    public class EmployeeLoanRepository : GenericRepository<EmployeeLoan>, IEmployeeLoanRepository
    {
        public EmployeeLoanRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
