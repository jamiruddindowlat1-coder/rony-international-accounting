using System;

namespace InternationalAccountingSystem.API.Dtos.Payroll
{
    public class SalaryComponentDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsTaxable { get; set; }
        public long GLAccountId { get; set; }
    }
}
