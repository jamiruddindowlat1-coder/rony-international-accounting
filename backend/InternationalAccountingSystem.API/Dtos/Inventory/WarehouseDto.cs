using System;

namespace InternationalAccountingSystem.API.Dtos.Inventory
{
    public class WarehouseDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long? BranchId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
