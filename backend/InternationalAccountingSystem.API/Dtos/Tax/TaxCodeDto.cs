using System;

namespace InternationalAccountingSystem.API.Dtos.Tax
{
    public class TaxCodeDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long TaxTypeId { get; set; }
        public long JurisdictionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool IsCompound { get; set; }
        public bool IsRecoverable { get; set; }
        public long? PayableAccountId { get; set; }
        public long? ReceivableAccountId { get; set; }
    }
}
