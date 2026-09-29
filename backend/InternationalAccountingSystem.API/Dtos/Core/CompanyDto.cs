using System;

namespace InternationalAccountingSystem.API.Dtos.Core
{
    public class CompanyDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string RegistrationNumber { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public string CountryCode { get; set; }
        public string BaseCurrencyCode { get; set; }
        public byte FiscalYearStartMonth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string LogoPath { get; set; }
        public bool IsActive { get; set; }
    }
}
