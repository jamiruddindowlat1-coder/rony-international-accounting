using System;

namespace InternationalAccountingSystem.API.Dtos.Accounting
{
    public class ChartOfAccountDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public long? ParentAccountId { get; set; }
        public long AccountGroupId { get; set; }
        public long AccountTypeId { get; set; }
        public string CurrencyCode { get; set; }
        public bool IsControlAccount { get; set; }
        public string ControlAccountFor { get; set; }
        public bool AllowManualEntry { get; set; }
        public decimal? OpeningBalance { get; set; }
        public DateTime? OpeningBalanceDate { get; set; }
        public bool IsActive { get; set; }
    }
}
