using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Security
{
    public class UserRole : BaseGlobalEntity
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }
    }
}
