using System;

namespace InternationalAccountingSystem.API.Dtos.Receivables
{
    public class SalesOrderDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long CustomerId { get; set; }
        public string SONumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRateToBase { get; set; }
    }
}
