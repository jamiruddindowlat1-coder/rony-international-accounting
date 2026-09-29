using System;

namespace InternationalAccountingSystem.API.Dtos.Payables
{
    public class VendorBankAccountDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long VendorId { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
        public string SwiftCode { get; set; }
        public string CurrencyCode { get; set; }
    }
}
