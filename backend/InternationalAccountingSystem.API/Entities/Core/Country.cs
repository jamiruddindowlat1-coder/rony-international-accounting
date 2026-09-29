using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Core
{
    public class Country : BaseGlobalEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
