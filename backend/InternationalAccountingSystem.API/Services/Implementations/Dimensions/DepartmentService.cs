using AutoMapper;
using InternationalAccountingSystem.API.Entities.Dimensions;
using InternationalAccountingSystem.API.Dtos.Dimensions;
using InternationalAccountingSystem.API.Repositories.Interfaces.Dimensions;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Dimensions;

namespace InternationalAccountingSystem.API.Services.Implementations.Dimensions
{
    public class DepartmentService : GenericService<Department, DepartmentDto>, IDepartmentService
    {
        public DepartmentService(IDepartmentRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
