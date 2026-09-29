using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Reporting
{
    public class FinancialStatementLine : BaseEntity
    {
        public long TemplateId { get; set; }
        public long? ParentLineId { get; set; }
        public string LineLabel { get; set; }
        public int LineOrder { get; set; }
        public string LineType { get; set; }
        public string Formula { get; set; }
    }
}
