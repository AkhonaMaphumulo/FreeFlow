using FreeFlow.Models;
using System;
using System.Collections.Generic;

namespace FreeFlow.ViewModels
{
    public class SOSViewModel
    {
        public bool UserLoggedIn { get; set; }
        public bool ShowSuccess { get; set; }
        public string SuccessMessage { get; set; } = string.Empty;
        public bool ShowError { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public bool ShowWarning { get; set; }
        public string WarningMessage { get; set; } = string.Empty;
        public bool ShowInfo { get; set; }
        public string InfoMessage { get; set; } = string.Empty;
        public bool HasResults { get; set; }
        public List<NearbySupportResult> NearbyPoints { get; set; } = new List<NearbySupportResult>();
        public int? EmergencyRequestId { get; set; }
    }

    public class NearbySupportResult
    {
        public SupportPoint SupportPoint { get; set; } = new SupportPoint();
        public double Distance { get; set; }
        public string DistanceText { get; set; } = string.Empty;
    }
}