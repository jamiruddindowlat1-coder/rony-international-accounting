using System;

namespace InternationalAccountingSystem.API.Dtos.Receivables
{
    public class CustomerContactDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long CustomerId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsPrimary { get; set; }
    }
}
