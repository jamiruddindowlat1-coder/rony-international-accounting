using System;

namespace InternationalAccountingSystem.API.Dtos.Banking
{
    public class BankStatementImportDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long BankAccountId { get; set; }
        public DateTime ImportDate { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
    }
}
