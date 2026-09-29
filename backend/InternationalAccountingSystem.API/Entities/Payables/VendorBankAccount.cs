using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payables
{
    public class VendorBankAccount : BaseEntity
    {
        public long VendorId { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
        public string SwiftCode { get; set; }
        public string CurrencyCode { get; set; }
    }
}
