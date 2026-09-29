using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Tax
{
    public class TaxType : BaseGlobalEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
