using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Security
{
    public class RolePermission : BaseGlobalEntity
    {
        public long RoleId { get; set; }
        public long PermissionId { get; set; }
    }
}
