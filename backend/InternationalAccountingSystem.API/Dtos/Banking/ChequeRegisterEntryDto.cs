using System;

namespace InternationalAccountingSystem.API.Dtos.Banking
{
    public class ChequeRegisterEntryDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
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
