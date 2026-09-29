using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.Dimensions;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.Dimensions;

namespace InternationalAccountingSystem.API.Repositories.Implementations.Dimensions
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
