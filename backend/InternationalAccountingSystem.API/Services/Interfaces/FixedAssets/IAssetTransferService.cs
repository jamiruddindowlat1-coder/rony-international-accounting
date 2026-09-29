using InternationalAccountingSystem.API.Entities.FixedAssets;
using InternationalAccountingSystem.API.Dtos.FixedAssets;
using InternationalAccountingSystem.API.Services.Generic;

namespace InternationalAccountingSystem.API.Services.Interfaces.FixedAssets
{
    public interface IAssetTransferService : IGenericService<AssetTransfer, AssetTransferDto>
    {
    }
}
