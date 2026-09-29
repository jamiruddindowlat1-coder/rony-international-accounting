using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Core
{
    public class NumberSequence : BaseEntity
    {
        public long? BranchId { get; set; }
        public string DocumentType { get; set; }
        public string Prefix { get; set; }
        public long NextNumber { get; set; }
        public byte PaddingLength { get; set; }
        public string ResetFrequency { get; set; }
        public DateTime? LastResetDate { get; set; }
    }
}
