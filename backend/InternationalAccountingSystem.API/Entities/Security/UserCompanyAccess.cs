using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Security
{
    public class UserCompanyAccess : BaseEntity
    {
        public long UserId { get; set; }
        public long? BranchId { get; set; }
        public bool IsDefault { get; set; }
    }
}
