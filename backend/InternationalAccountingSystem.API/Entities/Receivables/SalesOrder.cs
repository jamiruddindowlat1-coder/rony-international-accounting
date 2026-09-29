using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Receivables
{
    public class SalesOrder : BaseEntity
    {
        public long CustomerId { get; set; }
        public string SONumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRateToBase { get; set; }
    }
}
