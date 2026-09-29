using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Receivables;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Receivables;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Receivables
{
    public class SalesInvoiceLineRepository : GenericRepository<SalesInvoiceLine>, ISalesInvoiceLineRepository
    {
        public SalesInvoiceLineRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
