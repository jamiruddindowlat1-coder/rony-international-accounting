using System;

namespace InternationalAccountingSystem.API.Dtos.Payroll
{
    public class EmployeeLoanDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long EmployeeId { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal InstallmentAmount { get; set; }
        public DateTime StartDate { get; set; }
        public decimal OutstandingBalance { get; set; }
    }
}
