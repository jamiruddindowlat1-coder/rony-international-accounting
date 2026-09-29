using System;

namespace InternationalAccountingSystem.API.Dtos.Receivables
{
    public class CustomerReceiptAllocationDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long ReceiptId { get; set; }
        public long InvoiceId { get; set; }
        public decimal AllocatedAmount { get; set; }
    }
}
