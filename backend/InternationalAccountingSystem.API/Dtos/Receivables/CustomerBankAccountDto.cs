using System;

namespace InternationalAccountingSystem.API.Dtos.Receivables
{
    public class CustomerBankAccountDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long CustomerId { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
    }
}
