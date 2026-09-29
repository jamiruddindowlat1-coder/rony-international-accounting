using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class RefreshTokenDto
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string TokenHash { get; set; }
        public DateTime ExpiresAt { get; set; }
        public string CreatedByIp { get; set; }
        public DateTime? RevokedAt { get; set; }
        public string ReplacedByTokenHash { get; set; }
    }
}
