using System;

namespace InternationalAccountingSystem.API.Dtos.Banking
{
    public class BankAccountDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
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
