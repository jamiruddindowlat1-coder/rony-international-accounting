using System;

namespace InternationalAccountingSystem.API.Dtos.Inventory
{
    public class ItemCategoryDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string Name { get; set; }
    }
}
