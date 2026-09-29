using AutoMapper;
using InternationalAccountingSystem.API.Entities.Tax;
using InternationalAccountingSystem.API.Dtos.Tax;
using InternationalAccountingSystem.API.Repositories.Interfaces.Tax;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Tax;

namespace InternationalAccountingSystem.API.Services.Implementations.Tax
{
    public class TaxTypeService : GenericService<TaxType, TaxTypeDto>, ITaxTypeService
    {
        public TaxTypeService(ITaxTypeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
