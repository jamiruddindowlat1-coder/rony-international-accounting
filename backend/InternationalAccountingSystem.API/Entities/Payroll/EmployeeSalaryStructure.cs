using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payroll
{
    public class EmployeeSalaryStructure : BaseEntity
    {
        public long EmployeeId { get; set; }
        public long ComponentId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Percentage { get; set; }
        public DateTime EffectiveFrom { get; set; }
    }
}
