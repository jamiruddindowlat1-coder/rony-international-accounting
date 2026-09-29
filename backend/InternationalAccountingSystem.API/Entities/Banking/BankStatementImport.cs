using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Banking
{
    public class BankStatementImport : BaseEntity
    {
        public long BankAccountId { get; set; }
        public DateTime ImportDate { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
    }
}
