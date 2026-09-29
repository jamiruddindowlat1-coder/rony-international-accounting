using System;

namespace InternationalAccountingSystem.API.Dtos.Core
{
    public class NumberSequenceDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long? BranchId { get; set; }
        public string DocumentType { get; set; }
        public string Prefix { get; set; }
        public long NextNumber { get; set; }
        public byte PaddingLength { get; set; }
        public string ResetFrequency { get; set; }
        public DateTime? LastResetDate { get; set; }
    }
}
