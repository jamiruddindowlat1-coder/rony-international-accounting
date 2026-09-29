using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Security;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Security;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Security
{
    public class PermissionRepository : GenericRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
