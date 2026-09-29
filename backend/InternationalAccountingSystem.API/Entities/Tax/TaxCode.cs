using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Tax
{
    public class TaxCode : BaseEntity
    {
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
