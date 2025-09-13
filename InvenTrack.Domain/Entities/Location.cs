using InvenTrack.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace InvenTrack.Domain.Entities
{
    public class Location : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Type { get; set; } = "Warehouse"; // Warehouse, Store, Distribution Center

        public int? ManagerId { get; set; }

        [MaxLength(20)]
        public string? PostalCode { get; set; }

        [MaxLength(100)]
        public string? City { get; set; }

        [MaxLength(100)]
        public string? State { get; set; }

        [MaxLength(100)]
        public string? Country { get; set; }

        [MaxLength(20)]
        public string? ContactPhone { get; set; }

        [EmailAddress]
        [MaxLength(150)]
        public string? ContactEmail { get; set; }

        public bool IsDefault { get; set; } = false;

        // Navigation Properties
        public virtual User? Manager { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
    }
}
