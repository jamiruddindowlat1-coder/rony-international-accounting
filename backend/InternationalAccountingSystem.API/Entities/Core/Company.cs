using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Core
{
    public class Company : BaseGlobalEntity
    {
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
