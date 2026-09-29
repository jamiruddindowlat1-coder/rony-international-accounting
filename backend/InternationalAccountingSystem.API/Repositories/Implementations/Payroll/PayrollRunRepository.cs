using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Payroll;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Payroll;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Payroll
{
    public class PayrollRunRepository : GenericRepository<PayrollRun>, IPayrollRunRepository
    {
        public PayrollRunRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
