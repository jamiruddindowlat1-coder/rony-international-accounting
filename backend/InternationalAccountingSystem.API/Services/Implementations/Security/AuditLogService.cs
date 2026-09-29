using AutoMapper;
using InternationalAccountingSystem.API.Entities.Security;
using InternationalAccountingSystem.API.Dtos.Security;
using InternationalAccountingSystem.API.Repositories.Interfaces.Security;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Security;

namespace InternationalAccountingSystem.API.Services.Implementations.Security
{
    public class AuditLogService : GenericService<AuditLog, AuditLogDto>, IAuditLogService
    {
        public AuditLogService(IAuditLogRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
