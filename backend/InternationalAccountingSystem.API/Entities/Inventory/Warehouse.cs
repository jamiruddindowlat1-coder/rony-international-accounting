using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Inventory
{
    public class Warehouse : BaseEntity
    {
        public long? BranchId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
