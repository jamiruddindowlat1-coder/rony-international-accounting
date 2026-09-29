using AutoMapper;
using InternationalAccountingSystem.API.Entities.Dimensions;
using InternationalAccountingSystem.API.Dtos.Dimensions;
using InternationalAccountingSystem.API.Repositories.Interfaces.Dimensions;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Dimensions;

namespace InternationalAccountingSystem.API.Services.Implementations.Dimensions
{
    public class ProjectService : GenericService<Project, ProjectDto>, IProjectService
    {
        public ProjectService(IProjectRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
