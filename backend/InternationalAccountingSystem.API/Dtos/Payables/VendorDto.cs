using System;

namespace InternationalAccountingSystem.API.Dtos.Payables
{
    public class VendorDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
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
