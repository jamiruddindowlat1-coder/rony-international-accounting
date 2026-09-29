using System;

namespace InternationalAccountingSystem.API.Dtos.Payables
{
    public class PurchaseOrderDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long VendorId { get; set; }
        public string PONumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public string Status { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRateToBase { get; set; }
    }
}
