using System;

namespace InternationalAccountingSystem.API.Dtos.Tax
{
    public class TaxJurisdictionDto
    {
        public long Id { get; set; }
        public string CountryCode { get; set; }
        public string Region { get; set; }
        public string Name { get; set; }
    }
}
