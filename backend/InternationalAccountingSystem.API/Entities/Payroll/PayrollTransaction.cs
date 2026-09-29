using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payroll
{
    public class PayrollTransaction : BaseEntity
    {
        public long PayrollRunId { get; set; }
        public long EmployeeId { get; set; }
        public long ComponentId { get; set; }
        public decimal Amount { get; set; }
    }
}
