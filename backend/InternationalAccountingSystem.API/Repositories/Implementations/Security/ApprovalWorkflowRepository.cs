using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Security;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Security;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Security
{
    public class ApprovalWorkflowRepository : GenericRepository<ApprovalWorkflow>, IApprovalWorkflowRepository
    {
        public ApprovalWorkflowRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
