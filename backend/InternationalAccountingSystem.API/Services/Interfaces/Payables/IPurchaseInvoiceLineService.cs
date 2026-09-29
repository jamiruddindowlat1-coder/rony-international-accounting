using InternationalAccountingSystem.API.Entities.Payables;
using InternationalAccountingSystem.API.Dtos.Payables;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Payables
{
    public interface IPurchaseInvoiceLineService : IGenericService<PurchaseInvoiceLine, PurchaseInvoiceLineDto>
    {
    }
}
