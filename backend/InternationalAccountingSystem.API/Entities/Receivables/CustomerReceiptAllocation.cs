using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Receivables
{
    public class CustomerReceiptAllocation : BaseEntity
    {
        public long ReceiptId { get; set; }
        public long InvoiceId { get; set; }
        public decimal AllocatedAmount { get; set; }
    }
}
