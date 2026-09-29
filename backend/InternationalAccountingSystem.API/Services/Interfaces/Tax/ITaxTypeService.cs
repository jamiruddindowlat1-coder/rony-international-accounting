using InternationalAccountingSystem.API.Entities.Tax;
using InternationalAccountingSystem.API.Dtos.Tax;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Tax
{
    public interface ITaxTypeService : IGenericService<TaxType, TaxTypeDto>
    {
    }
}
