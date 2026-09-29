using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Core
{
    public class Branch : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public bool IsHeadOffice { get; set; }
        public bool IsActive { get; set; }
    }
}
