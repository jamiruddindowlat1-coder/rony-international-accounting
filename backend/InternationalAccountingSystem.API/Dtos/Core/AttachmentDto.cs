using System;

namespace InternationalAccountingSystem.API.Dtos.Core
{
    public class AttachmentDto
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
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
