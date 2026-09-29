using System;

namespace InternationalAccountingSystem.API.Dtos.Banking
{
    public class PettyCashAccountDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string Name { get; set; }
        public long CustodianUserId { get; set; }
        public long GLAccountId { get; set; }
        public decimal ImprestLimit { get; set; }
    }
}
