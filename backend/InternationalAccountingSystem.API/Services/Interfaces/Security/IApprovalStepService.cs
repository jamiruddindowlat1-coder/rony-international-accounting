using InternationalAccountingSystem.API.Entities.Security;
using InternationalAccountingSystem.API.Dtos.Security;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Security
{
    public interface IApprovalStepService : IGenericService<ApprovalStep, ApprovalStepDto>
    {
    }
}
