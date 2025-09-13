using InvenTrack.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace InvenTrack.Domain.Entities
{
    public class AuditLog : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string EntityName { get; set; } = string.Empty;

        [Required]
        public int EntityId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Action { get; set; } = string.Empty; // CREATE, UPDATE, DELETE, READ

        public int? UserId { get; set; }

        [Required]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public string? Changes { get; set; } // JSON string of changes

        public string? OldValues { get; set; } // JSON string of old values

        public string? NewValues { get; set; } // JSON string of new values

        [MaxLength(45)] // IPv6 max length
        public string? IpAddress { get; set; }

        [MaxLength(500)]
        public string? UserAgent { get; set; }

        [MaxLength(200)]
        public string? Module { get; set; } // Which module/controller performed the action

        [MaxLength(500)]
        public string? AdditionalInfo { get; set; }

        public bool IsSuccessful { get; set; } = true;

        [MaxLength(1000)]
        public string? ErrorMessage { get; set; }

        // Navigation Properties
        public virtual User? User { get; set; }

        // Business Logic Methods
        public void SetChanges(object? oldValue, object? newValue)
        {
            if (oldValue != null)
                OldValues = System.Text.Json.JsonSerializer.Serialize(oldValue);
            if (newValue != null)
                NewValues = System.Text.Json.JsonSerializer.Serialize(newValue);
        }

        public void SetError(string errorMessage)
        {
            IsSuccessful = false;
            ErrorMessage = errorMessage;
        }
    }
}
