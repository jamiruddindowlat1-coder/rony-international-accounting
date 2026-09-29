using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Receivables
{
    public class CustomerReceipt : BaseEntity
    {
        public long CustomerId { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string PaymentMethod { get; set; }
        public long BankAccountId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRateToBase { get; set; }
        public decimal Amount { get; set; }
        public long? JournalEntryId { get; set; }
        public string Status { get; set; }
    }
}
