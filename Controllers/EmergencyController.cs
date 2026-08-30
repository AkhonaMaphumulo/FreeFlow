using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FreeFlow.Data; // Adjust to your namespace
using FreeFlow.Models;

namespace FreeFlow.Controllers
{
    public class EmergencyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmergencyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Emergency/SOS
        public IActionResult SOS()
        {
            return View();
        }

        // POST: Emergency/SubmitSOS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitSOS(string locationArea, string urgencyLevel)
        {
            if (!string.IsNullOrWhiteSpace(locationArea))
            {
                var sosEntry = new SOSRequest
                {
                    LocationArea = locationArea.Trim(),
                    UrgencyLevel = urgencyLevel ?? "Immediate",
                    RequestedAt = DateTime.UtcNow
                };

                _context.SOSRequests.Add(sosEntry);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "🚨 Your SOS request has been logged. Help is on the way!";
            }

            return RedirectToAction(nameof(SOS));
        }

        // GET: Emergency/NGODashboard
        public async Task<IActionResult> NGODashboard()
        {
            // Group demand by location area to generate actionable insights
            var areaDemandInsights = await _context.SOSRequests
                .GroupBy(r => r.LocationArea)
                .Select(g => new NGOAreaInsightViewModel
                {
                    LocationArea = g.Key,
                    TotalPadsNeeded = g.Count(), // 1 SOS = 1 requested emergency supply unit
                    PendingRequests = g.Count(r => !r.IsFulfilled),
                    LastRequested = g.Max(r => r.RequestedAt)
                })
                .OrderByDescending(i => i.TotalPadsNeeded)
                .ToListAsync();

            ViewBag.TotalSOSCount = await _context.SOSRequests.CountAsync();

            return View(areaDemandInsights);
        }
    }

    // View Model for NGO Dashboard Insights
    public class NGOAreaInsightViewModel
    {
        public string LocationArea { get; set; } = string.Empty;
        public int TotalPadsNeeded { get; set; }
        public int PendingRequests { get; set; }
        public DateTime LastRequested { get; set; }
    }
}