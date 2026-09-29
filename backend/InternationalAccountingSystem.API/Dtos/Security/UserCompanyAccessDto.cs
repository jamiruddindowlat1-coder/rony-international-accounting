using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class UserCompanyAccessDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long UserId { get; set; }
        public long? BranchId { get; set; }
        public bool IsDefault { get; set; }
    }
}
