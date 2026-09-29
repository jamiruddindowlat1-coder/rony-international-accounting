using InternationalAccountingSystem.API.Entities.Core;
using InternationalAccountingSystem.API.Dtos.Core;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.Core
{
    public interface ICountryService : IGenericService<Country, CountryDto>
    {
    }
}
