using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Dimensions;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Dimensions;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Dimensions
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
