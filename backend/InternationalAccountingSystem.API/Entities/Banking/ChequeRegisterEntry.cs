using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Banking
{
    public class ChequeRegisterEntry : BaseEntity
    {
        public long BankAccountId { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime ChequeDate { get; set; }
        public string Direction { get; set; }
        public string PartyType { get; set; }
        public long? PartyId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public long? LinkedPaymentId { get; set; }
        public long? LinkedReceiptId { get; set; }
    }
}
