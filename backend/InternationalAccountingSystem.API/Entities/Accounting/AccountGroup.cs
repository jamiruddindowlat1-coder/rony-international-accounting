using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Accounting
{
    public class AccountGroup : BaseEntity
    {
        public long? ParentGroupId { get; set; }
        public string Name { get; set; }
        public long AccountTypeId { get; set; }
        public int DisplayOrder { get; set; }
    }
}
