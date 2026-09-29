using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Banking
{
    public class BankAccount : BaseEntity
    {
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
        public string SwiftCode { get; set; }
        public string CurrencyCode { get; set; }
        public long GLAccountId { get; set; }
        public decimal OpeningBalance { get; set; }
        public bool IsActive { get; set; }
    }
}
