using System.ComponentModel.DataAnnotations;

namespace FreeFlow.Models
{
    public class EmergencyRequest
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        public string? LocationName { get; set; }

        public bool IsResolved { get; set; } = false;

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ResolvedDate { get; set; }

        public string? Notes { get; set; }
    }
}