using InternationalAccountingSystem.API.Data;
using InternationalAccountingSystem.API.Entities.FixedAssets;
using InternationalAccountingSystem.API.Repositories.Generic;
using InternationalAccountingSystem.API.Repositories.Interfaces.FixedAssets;

namespace InternationalAccountingSystem.API.Repositories.Implementations.FixedAssets
{
    public class AssetMaintenanceLogRepository : GenericRepository<AssetMaintenanceLog>, IAssetMaintenanceLogRepository
    {
        public AssetMaintenanceLogRepository(InternationalAccountingSystem.API.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
