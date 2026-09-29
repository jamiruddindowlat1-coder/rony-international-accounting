using System;

namespace InternationalAccountingSystem.API.Dtos.Core
{
    public class BranchDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public bool IsHeadOffice { get; set; }
        public bool IsActive { get; set; }
    }
}
