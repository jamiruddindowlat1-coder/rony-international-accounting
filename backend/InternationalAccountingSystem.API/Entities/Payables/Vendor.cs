using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payables
{
    public class Vendor : BaseEntity
    {
        public string VendorCode { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public string CountryCode { get; set; }
        public string DefaultCurrencyCode { get; set; }
        public int PaymentTermsDays { get; set; }
        public long ControlAccountId { get; set; }
        public long? DefaultExpenseAccountId { get; set; }
        public decimal? CreditLimit { get; set; }
        public bool IsActive { get; set; }
    }
}
