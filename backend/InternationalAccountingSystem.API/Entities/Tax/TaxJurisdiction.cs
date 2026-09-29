using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Tax
{
    public class TaxJurisdiction : BaseGlobalEntity
    {
        public string CountryCode { get; set; }
        public string Region { get; set; }
        public string Name { get; set; }
    }
}
