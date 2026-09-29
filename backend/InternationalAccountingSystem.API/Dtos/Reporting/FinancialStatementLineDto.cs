using System;

namespace InternationalAccountingSystem.API.Dtos.Reporting
{
    public class FinancialStatementLineDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long TemplateId { get; set; }
        public long? ParentLineId { get; set; }
        public string LineLabel { get; set; }
        public int LineOrder { get; set; }
        public string LineType { get; set; }
        public string Formula { get; set; }
    }
}
