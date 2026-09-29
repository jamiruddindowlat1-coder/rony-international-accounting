using System;

namespace InternationalAccountingSystem.API.Dtos.Payables
{
    public class VendorPaymentDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long VendorId { get; set; }
        public string PaymentNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public long BankAccountId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRateToBase { get; set; }
        public decimal Amount { get; set; }
        public long? JournalEntryId { get; set; }
        public string Status { get; set; }
    }
}
