using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Security
{
    public class Permission : BaseGlobalEntity
    {
        public string ModuleName { get; set; }
        public string Action { get; set; }
        public string Code { get; set; }
    }
}
