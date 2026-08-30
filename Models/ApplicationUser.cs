using Microsoft.AspNetCore.Identity;

namespace FreeFlow.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public string? PreferredLanguage { get; set; }
        public bool IsAdmin { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}