using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Accounting
{
    public class AccountType : BaseGlobalEntity
    {
        public string Name { get; set; }
        public string NormalBalance { get; set; }
    }
}
