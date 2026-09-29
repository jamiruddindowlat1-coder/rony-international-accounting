using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payroll
{
    public class EmployeeLoan : BaseEntity
    {
        public long EmployeeId { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal InstallmentAmount { get; set; }
        public DateTime StartDate { get; set; }
        public decimal OutstandingBalance { get; set; }
    }
}
