// Models/SupportPoint.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeFlow.Models
{
    public class SupportPoint
    {
        //  Primary Key
        public int Id { get; set; }

        //  Basic Info
        [Required]
        [Display(Name = "🏥 Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "📋 Type")]
        public string Type { get; set; } = string.Empty; // Clinic, Pharmacy, Support Centre, etc.

        //  Location
        [Required]
        [Display(Name = "📍 Latitude")]
        public double Latitude { get; set; }

        [Required]
        [Display(Name = "📍 Longitude")]
        public double Longitude { get; set; }

        //  Contact Info
        [Display(Name = "📌 Address")]
        public string? Address { get; set; }

        [Display(Name = "📞 Phone Number")]
        [Phone]
        public string? Phone { get; set; }

        [Display(Name = "📱 Emergency Contact")]
        [Phone]
        public string? EmergencyContact { get; set; }

        [Display(Name = "🌐 Website")]
        [Url]
        public string? Website { get; set; }

        // Hours
        [Display(Name = "🕐 Operating Hours")]
        public string? OperatingHours { get; set; }

        //  Stock Information
        [Display(Name = "Has Free Pads?")]
        public bool HasFreePads { get; set; } = false;

        [Display(Name = "📦 Pads in Stock")]
        [Range(0, 1000)]
        public int PadsInStock { get; set; } = 0;

        [Display(Name = "📅 Last Stock Update")]
        public DateTime LastStockUpdate { get; set; } = DateTime.Now;

        // Verification & Status
        [Display(Name = "✅ Is Verified")]
        public bool IsVerified { get; set; } = false;

        [Display(Name = "🟢 Is Active")]
        public bool IsActive { get; set; } = true;

        //  Additional Info
        [Display(Name = "💬 Notes")]
        public string? Notes { get; set; }

        [Display(Name = "♿ Accessibility")]
        public string? AccessibilityNotes { get; set; } // "Wheelchair accessible", "Ground floor", etc.

        [Display(Name = "💬 Languages Spoken")]
        public string? LanguagesSpoken { get; set; } // "English, Zulu, Xhosa"

        //  Services
        [Display(Name = "🚚 Offers Emergency Delivery")]
        public bool OffersEmergencyDelivery { get; set; } = false;

        [Display(Name = "🌙 24/7 Available")]
        public bool Is24Hours { get; set; } = false;

        [Display(Name = "👩‍⚕️ Has Nurse/Clinician")]
        public bool HasMedicalStaff { get; set; } = false;

        //  Target Audience
        [Display(Name = "👩 For Teens")]
        public bool ServesTeens { get; set; } = true;

        [Display(Name = "👩 For Adults")]
        public bool ServesAdults { get; set; } = true;

        //  User Ratings
        [Display(Name = "⭐ User Rating")]
        [Range(0, 5)]
        public double Rating { get; set; } = 0;

        [Display(Name = "💬 Number of Reviews")]
        public int ReviewCount { get; set; } = 0;

        //  Audit
        [Display(Name = "📅 Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "✏️ Last Modified")]
        public DateTime? LastModified { get; set; }

        [Display(Name = "👤 Created By")]
        public string? CreatedBy { get; set; }

        // Computed Properties (not stored in database)
        [NotMapped]
        [Display(Name = "📊 Stock Status")]
        public string StockStatus => HasFreePads && PadsInStock > 0
            ? $"✅ {PadsInStock} packs available!"
            : "❌ Currently out of stock - check back later! 💕";

        [NotMapped]
        [Display(Name = "💬 Display Name")]
        public string DisplayName => $"{Name} {(IsVerified ? "✅" : "⏳")}";

        [NotMapped]
        [Display(Name = "📞 Quick Contact")]
        public string QuickContact => Phone ?? EmergencyContact ?? "No contact available";

        [NotMapped]
        [Display(Name = "🚚 Delivery Available")]
        public bool DeliveryAvailable => OffersEmergencyDelivery && HasFreePads;

        [NotMapped]
        [Display(Name = "⭐ Rating Display")]
        public string RatingDisplay => Rating > 0
            ? $"⭐ {Rating:F1} ({ReviewCount} reviews)"
            : "⭐ No reviews yet";
    }
}