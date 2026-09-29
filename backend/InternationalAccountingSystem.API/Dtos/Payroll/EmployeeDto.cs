using System;

namespace InternationalAccountingSystem.API.Dtos.Payroll
{
    public class EmployeeDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string EmployeeCode { get; set; }
        public string Name { get; set; }
        public long? DepartmentId { get; set; }
        public DateTime JoinDate { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public decimal BasicSalary { get; set; }
        public long? PayableAccountId { get; set; }
        public bool IsActive { get; set; }
    }
}
