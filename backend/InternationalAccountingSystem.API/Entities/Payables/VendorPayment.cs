using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payables
{
    public class VendorPayment : BaseEntity
    {
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
