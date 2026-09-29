using System;
using InternationalAccountingSystem.API.Common;

namespace InternationalAccountingSystem.API.Entities.Core
{
    public class Attachment : BaseEntity
    {
        public string EntityType { get; set; }
        public long EntityId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public long FileSizeBytes { get; set; }
        public string ContentType { get; set; }
        public long? UploadedBy { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}
