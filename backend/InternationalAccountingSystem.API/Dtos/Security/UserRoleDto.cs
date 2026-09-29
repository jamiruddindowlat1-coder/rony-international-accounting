using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class UserRoleDto
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long RoleId { get; set; }
    }
}
