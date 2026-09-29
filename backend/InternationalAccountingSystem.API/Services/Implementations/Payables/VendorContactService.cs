using AutoMapper;
using InternationalAccountingSystem.API.Entities.Payables;
using InternationalAccountingSystem.API.Dtos.Payables;
using InternationalAccountingSystem.API.Repositories.Interfaces.Payables;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Payables;

namespace InternationalAccountingSystem.API.Services.Implementations.Payables
{
    public class VendorContactService : GenericService<VendorContact, VendorContactDto>, IVendorContactService
    {
        public VendorContactService(IVendorContactRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
