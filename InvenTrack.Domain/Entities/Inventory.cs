using InvenTrack.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace InvenTrack.Domain.Entities
{
    public class Inventory
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int LocationId { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative")]
        public int Quantity { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Reorder level cannot be negative")]
        public int ReorderLevel { get; set; } = 10;

        [Range(0, int.MaxValue, ErrorMessage = "Maximum stock level cannot be negative")]
        public int? MaxStockLevel { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Reserved quantity cannot be negative")]
        public int ReservedQuantity { get; set; } = 0;

        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        public DateTime? LastRestocked { get; set; }

        [MaxLength(500)]
        public string? Notes { get; set; }

        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual Product Product { get; set; } = null!;
        public virtual Location Location { get; set; } = null!;

        // Business Logic Properties
        public int AvailableQuantity => Quantity - ReservedQuantity;
        public bool IsLowStock => Quantity <= ReorderLevel;
        public bool IsOutOfStock => Quantity <= 0;
        public bool IsOverStocked => MaxStockLevel.HasValue && Quantity > MaxStockLevel;

        // Business Logic Methods
        public bool CanReserve(int requestedQuantity)
        {
            return AvailableQuantity >= requestedQuantity;
        }

        public void ReserveStock(int quantity)
        {
            if (CanReserve(quantity))
            {
                ReservedQuantity += quantity;
                LastUpdated = DateTime.UtcNow;
            }
            else
            {
                throw new InvalidOperationException("Insufficient available stock to reserve.");
            }
        }

        public void ReleaseReservedStock(int quantity)
        {
            if (ReservedQuantity >= quantity)
            {
                ReservedQuantity -= quantity;
                LastUpdated = DateTime.UtcNow;
            }
        }

        public void DeductStock(int quantity)
        {
            if (Quantity >= quantity)
            {
                Quantity -= quantity;
                LastUpdated = DateTime.UtcNow;
            }
            else
            {
                throw new InvalidOperationException("Insufficient stock to deduct.");
            }
        }

        public void AddStock(int quantity)
        {
            Quantity += quantity;
            LastUpdated = DateTime.UtcNow;
            LastRestocked = DateTime.UtcNow;
        }
    }
}
