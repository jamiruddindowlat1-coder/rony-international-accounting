using System;

namespace InternationalAccountingSystem.API.Dtos.Payroll
{
    public class PayrollTransactionDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long PayrollRunId { get; set; }
        public long EmployeeId { get; set; }
        public long ComponentId { get; set; }
        public decimal Amount { get; set; }
    }
}
