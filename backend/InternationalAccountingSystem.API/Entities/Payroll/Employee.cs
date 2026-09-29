using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payroll
{
    public class Employee : BaseEntity
    {
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
