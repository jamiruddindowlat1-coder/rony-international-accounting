using System;

namespace InternationalAccountingSystem.API.Dtos.Payables
{
    public class VendorPaymentAllocationDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long PaymentId { get; set; }
        public long InvoiceId { get; set; }
        public decimal AllocatedAmount { get; set; }
    }
}
