using System;

namespace InternationalAccountingSystem.API.Dtos.Dimensions
{
    public class CostCenterDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long? DepartmentId { get; set; }
    }
}
