using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Security;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Security;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Security
{
    public class ApprovalRequestRepository : GenericRepository<ApprovalRequest>, IApprovalRequestRepository
    {
        public ApprovalRequestRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
