using System;

namespace InternationalAccountingSystem.API.Common
{
    /// <summary>
    /// Standard columns present on every tenant-scoped business table.
    /// </summary>
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
        public byte[]? RowVersion { get; set; }
    }

    /// <summary>
    /// Standard columns for global/master lookup tables that are not
    /// scoped to a single Company (Countries, Currencies, Permissions...).
    /// </summary>
    public abstract class BaseGlobalEntity
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
