using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Receivables
{
    public class Customer : BaseEntity
    {
        public string CustomerCode { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public string CountryCode { get; set; }
        public string DefaultCurrencyCode { get; set; }
        public int PaymentTermsDays { get; set; }
        public long ControlAccountId { get; set; }
        public decimal? CreditLimit { get; set; }
        public bool IsActive { get; set; }
    }
}
