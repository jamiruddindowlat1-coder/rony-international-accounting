using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Payables;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Payables;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Payables
{
    public class PurchaseInvoiceRepository : GenericRepository<PurchaseInvoice>, IPurchaseInvoiceRepository
    {
        public PurchaseInvoiceRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
