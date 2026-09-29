using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Receivables
{
    public class CustomerBankAccount : BaseEntity
    {
        public long CustomerId { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
    }
}
