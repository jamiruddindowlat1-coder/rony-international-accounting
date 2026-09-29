using AutoMapper;
using InternationalAccountingSystem.API.Entities.FixedAssets;
using InternationalAccountingSystem.API.Dtos.FixedAssets;
using InternationalAccountingSystem.API.Repositories.Interfaces.FixedAssets;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.FixedAssets;

namespace InternationalAccountingSystem.API.Services.Implementations.FixedAssets
{
    public class FixedAssetService : GenericService<FixedAsset, FixedAssetDto>, IFixedAssetService
    {
        public FixedAssetService(IFixedAssetRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
