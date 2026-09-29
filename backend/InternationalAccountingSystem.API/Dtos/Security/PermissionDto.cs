using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class PermissionDto
    {
        public long Id { get; set; }
        public string ModuleName { get; set; }
        public string Action { get; set; }
        public string Code { get; set; }
    }
}
