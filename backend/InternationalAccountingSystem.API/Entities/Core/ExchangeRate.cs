using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Core
{
    public class ExchangeRate : BaseEntity
    {
        public string FromCurrencyCode { get; set; }
        public string ToCurrencyCode { get; set; }
        public DateTime RateDate { get; set; }
        public decimal Rate { get; set; }
        public string RateType { get; set; }
        public string Source { get; set; }
    }
}
