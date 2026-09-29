using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class RoleDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSystemRole { get; set; }
    }
}
