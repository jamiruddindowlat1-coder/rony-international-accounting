using InternationalAccountingSystem.API.Entities.Payroll;
using InternationalAccountingSystem.API.Dtos.Payroll;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Payroll
{
    public interface IEmployeeSalaryStructureService : IGenericService<EmployeeSalaryStructure, EmployeeSalaryStructureDto>
    {
    }
}
