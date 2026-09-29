using System;

namespace InternationalAccountingSystem.API.Dtos.Accounting
{
    public class AccountGroupDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long? ParentGroupId { get; set; }
        public string Name { get; set; }
        public long AccountTypeId { get; set; }
        public int DisplayOrder { get; set; }
    }
}
