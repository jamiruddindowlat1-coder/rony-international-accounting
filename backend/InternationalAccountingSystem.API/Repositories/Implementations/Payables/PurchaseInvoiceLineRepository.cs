using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Payables;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Payables;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Payables
{
    public class PurchaseInvoiceLineRepository : GenericRepository<PurchaseInvoiceLine>, IPurchaseInvoiceLineRepository
    {
        public PurchaseInvoiceLineRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
