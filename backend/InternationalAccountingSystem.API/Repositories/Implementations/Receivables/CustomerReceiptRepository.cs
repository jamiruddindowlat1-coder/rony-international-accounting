using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Receivables;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Receivables;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Receivables
{
    public class CustomerReceiptRepository : GenericRepository<CustomerReceipt>, ICustomerReceiptRepository
    {
        public CustomerReceiptRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
