using AutoMapper;
using InternationalAccountingSystem.API.Entities.FixedAssets;
using InternationalAccountingSystem.API.Dtos.FixedAssets;
using InternationalAccountingSystem.API.Repositories.Interfaces.FixedAssets;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.FixedAssets;

namespace InternationalAccountingSystem.API.Services.Implementations.FixedAssets
{
    public class AssetDisposalService : GenericService<AssetDisposal, AssetDisposalDto>, IAssetDisposalService
    {
        public AssetDisposalService(IAssetDisposalRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
