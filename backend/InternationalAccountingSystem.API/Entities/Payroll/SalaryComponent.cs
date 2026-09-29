using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payroll
{
    public class SalaryComponent : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsTaxable { get; set; }
        public long GLAccountId { get; set; }
    }
}
