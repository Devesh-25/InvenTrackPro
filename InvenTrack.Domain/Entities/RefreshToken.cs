using InvenTrack.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace InvenTrack.Domain.Entities
{
    public class RefreshToken : BaseEntity
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Token { get; set; } = string.Empty;

        [Required]
        public DateTime ExpiryDate { get; set; }

        public bool IsRevoked { get; set; } = false;

        public bool IsUsed { get; set; } = false;

        public DateTime? RevokedAt { get; set; }

        public DateTime? UsedAt { get; set; }

        [MaxLength(45)] // IPv6 max length
        public string? IpAddress { get; set; }

        [MaxLength(500)]
        public string? UserAgent { get; set; }

        [MaxLength(200)]
        public string? ReasonRevoked { get; set; }

        public int? ReplacedByTokenId { get; set; }

        // Navigation Properties
        public virtual User User { get; set; } = null!;
        public virtual RefreshToken? ReplacedByToken { get; set; }

        // Business Logic Properties
        public bool IsExpired => DateTime.UtcNow >= ExpiryDate;
        public bool IsValidForUse => !IsRevoked && !IsUsed && !IsExpired && IsActive;

        // Business Logic Methods
        public void Revoke(string reason = "")
        {
            IsRevoked = true;
            RevokedAt = DateTime.UtcNow;
            ReasonRevoked = reason;
        }

        public void MarkAsUsed()
        {
            IsUsed = true;
            UsedAt = DateTime.UtcNow;
        }
    }
}
