using FreeFlow.Models;
using System;
using System.Linq;

namespace FreeFlow.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Check if SupportPoints already has data
            if (context.SupportPoints.Any())
            {
                return; // Data already exists, don't add more
            }

            // DURBAN SUPPORT POINTS WITH FREE PADS!
            var supportPoints = new SupportPoint[]
            {
                new SupportPoint
                {
                    Name = "🌸 Save the Dignity of Our School Girls",
                    Type = "NPO / School Programme",
                    Latitude = -29.9118,
                    Longitude = 30.9695,
                    Address = "Merebank, Durban South",
                    Phone = "079 565 1567",
                    EmergencyContact = "079 565 1567",
                    OperatingHours = "Mon-Fri 9am-5pm (by arrangement)",
                    HasFreePads = true,
                    PadsInStock = 200,
                    LastStockUpdate = DateTime.Now,
                    IsVerified = true,
                    IsActive = true,
                    Notes = "🌸 Founded by Roshni Naicker. Distributed 30,000+ pads since 2021. Supports 200 girls monthly across 8 primary schools in Merebank, Bluff, Chatsworth, Phoenix, and Tongaat.",
                    AccessibilityNotes = "♿ Call ahead - home-based distribution",
                    LanguagesSpoken = "English, Zulu",
                    OffersEmergencyDelivery = false,
                    Is24Hours = false,
                    HasMedicalStaff = false,
                    ServesTeens = true,
                    ServesAdults = false,
                    Rating = 4.9,
                    ReviewCount = 45,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "System"
                },
                new SupportPoint
                {
                    Name = "💎 Dignified Diamonds",
                    Type = "NPO / School Outreach",
                    Latitude = -29.9278,
                    Longitude = 31.0215,
                    Address = "Wentworth, Durban South",
                    Phone = "Contact via Southlands Sun",
                    EmergencyContact = "Contact via Southlands Sun",
                    OperatingHours = "School outreach programmes",
                    HasFreePads = true,
                    PadsInStock = 150,
                    LastStockUpdate = DateTime.Now,
                    IsVerified = true,
                    IsActive = true,
                    Notes = "💎 Led by Elaine Pieterse. Donated 1,600+ pads to Durban South high schools. Supports Fairvale Secondary, Umbilo Secondary, Wentworth High, Ganges Secondary, PR Pather Secondary, Merebank High, and Grosvenor Girls' High.",
                    AccessibilityNotes = "♿ School-based distribution",
                    LanguagesSpoken = "English, Zulu",
                    OffersEmergencyDelivery = false,
                    Is24Hours = false,
                    HasMedicalStaff = false,
                    ServesTeens = true,
                    ServesAdults = false,
                    Rating = 4.7,
                    ReviewCount = 28,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "System"
                },
                new SupportPoint
                {
                    Name = "😇 Angel Network Durban",
                    Type = "NPO / Women's Empowerment",
                    Latitude = -29.9278,
                    Longitude = 31.0215,
                    Address = "Wentworth, Durban",
                    Phone = "Contact via Good Things Guy",
                    EmergencyContact = "Contact via Good Things Guy",
                    OperatingHours = "Monthly outreach campaigns",
                    HasFreePads = true,
                    PadsInStock = 180,
                    LastStockUpdate = DateTime.Now,
                    IsVerified = true,
                    IsActive = true,
                    Notes = "😇 Provides thousands of schoolgirls with sanitary pads and SUBZ reusable pads. Recent outreach included hampers with toiletries and an inspirational talk from Mrs KwaZulu-Natal. Helps prevent girls from missing up to 80 school days per year.",
                    AccessibilityNotes = "♿ Community hall events",
                    LanguagesSpoken = "English, Zulu",
                    OffersEmergencyDelivery = false,
                    Is24Hours = false,
                    HasMedicalStaff = false,
                    ServesTeens = true,
                    ServesAdults = true,
                    Rating = 4.9,
                    ReviewCount = 42,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "System"
                },
                new SupportPoint
                {
                    Name = "🚶 Walk of Dignity - Kambambeni Foundation",
                    Type = "NGO / Campaign",
                    Latitude = -29.8587,
                    Longitude = 31.0218,
                    Address = "Durban Beach Front, KZN",
                    Phone = "www.walkofdignity.co.za",
                    EmergencyContact = "www.walkofdignity.co.za",
                    OperatingHours = "Campaign-based",
                    HasFreePads = true,
                    PadsInStock = 200,
                    LastStockUpdate = DateTime.Now,
                    IsVerified = true,
                    IsActive = true,
                    Notes = "🚶 Founded by Ndiswa Ndaba. Completed 720km walk from Johannesburg to Durban raising R1.4 million for sanitary dignity. Supports 10 resource-deficient schools with sanitary products, safe water, and hygiene facilities.",
                    AccessibilityNotes = "♿ School-based distribution",
                    LanguagesSpoken = "English, Zulu, Xhosa",
                    OffersEmergencyDelivery = false,
                    Is24Hours = false,
                    HasMedicalStaff = false,
                    ServesTeens = true,
                    ServesAdults = true,
                    Rating = 4.8,
                    ReviewCount = 34,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "System"
                },
                new SupportPoint
                {
                    Name = "🤝 Humanity South Africa",
                    Type = "NPO / Humanitarian",
                    Latitude = -29.7214,
                    Longitude = 31.0187,
                    Address = "Peter Mokaba Ridge, Durban",
                    Phone = "www.humanitysa.org",
                    EmergencyContact = "www.humanitysa.org",
                    OperatingHours = "Mon-Fri 9am-5pm",
                    HasFreePads = true,
                    PadsInStock = 250,
                    LastStockUpdate = DateTime.Now,
                    IsVerified = true,
                    IsActive = true,
                    Notes = "🤝 Runs 'Dignity 4 Her' project providing menstrual health education and sanitary pad distribution. Active in local schools including Grove End Secondary in Phoenix. Provides Section 18A tax certificates for donors.",
                    AccessibilityNotes = "♿ Office accessible",
                    LanguagesSpoken = "English, Zulu, Xhosa",
                    OffersEmergencyDelivery = false,
                    Is24Hours = false,
                    HasMedicalStaff = false,
                    ServesTeens = true,
                    ServesAdults = true,
                    Rating = 4.6,
                    ReviewCount = 32,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "System"
                }
            };

            context.SupportPoints.AddRange(supportPoints);
            context.SaveChanges();
        }
    }
}