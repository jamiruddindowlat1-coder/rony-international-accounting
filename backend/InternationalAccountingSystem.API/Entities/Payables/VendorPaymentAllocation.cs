using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Payables
{
    public class VendorPaymentAllocation : BaseEntity
    {
        public long PaymentId { get; set; }
        public long InvoiceId { get; set; }
        public decimal AllocatedAmount { get; set; }
    }
}
