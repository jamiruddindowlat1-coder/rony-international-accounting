using System;

namespace InternationalAccountingSystem.API.Dtos.Core
{
    public class ExchangeRateDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string FromCurrencyCode { get; set; }
        public string ToCurrencyCode { get; set; }
        public DateTime RateDate { get; set; }
        public decimal Rate { get; set; }
        public string RateType { get; set; }
        public string Source { get; set; }
    }
}
