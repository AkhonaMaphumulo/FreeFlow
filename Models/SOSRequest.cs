using System;
using System.ComponentModel.DataAnnotations;

namespace FreeFlow.Models
{
    public class SOSRequest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string LocationArea { get; set; } = string.Empty; // e.g., "North District", "School Ward 4"

        public string? UrgencyLevel { get; set; } = "Immediate"; // e.g., Low, Medium, High, Immediate

        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;

        public bool IsFulfilled { get; set; } = false;
    }
}