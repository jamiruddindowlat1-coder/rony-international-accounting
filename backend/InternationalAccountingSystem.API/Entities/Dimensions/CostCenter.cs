using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Dimensions
{
    public class CostCenter : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public long? DepartmentId { get; set; }
    }
}
