using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class RolePermissionDto
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public long PermissionId { get; set; }
    }
}
