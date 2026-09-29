using System;

namespace InternationalAccountingSystem.API.Dtos.Security
{
    public class UserDto
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsEmailVerified { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsTwoFactorEnabled { get; set; }
        public string TwoFactorSecretEncrypted { get; set; }
        public bool IsActive { get; set; }
        public bool IsLocked { get; set; }
        public int FailedLoginAttempts { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public DateTime? LastPasswordChangeAt { get; set; }
        public bool MustChangePassword { get; set; }
    }
}
