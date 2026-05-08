using System.Text.Json;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Services.Interfaces;

namespace InvoiceMenagment.Api.Services
{
    public class LicenseService : ILicenseService
    {
        private readonly string _licensePath = Path.Combine(Directory.GetCurrentDirectory(), "License", "client.lic");

        public LicenseModel? LoadLicense()
        {
            if (!File.Exists(_licensePath))
                return null;

            var json = File.ReadAllText(_licensePath);
            return JsonSerializer.Deserialize<LicenseModel>(json);
        }

        public bool IsLicenseValid()
        {
            var license = LoadLicense();
            if (license == null)
                return false;

            var today = DateTime.UtcNow.Date;
            return today >= license.StartDate.Date && today <= license.EndDate.Date;
        }

        public string GetLicenseStatusMessage()
        {
            var license = LoadLicense();
            if (license == null)
                return "License not found expire.";

            var today = DateTime.UtcNow.Date;
            if (today > license.EndDate.Date)
            {
                return $"Your license expired on {license.EndDate:yyyy-MM-dd}. Please renew it to continue.";
            }

            var daysRemaining = (license.EndDate.Date - today).Days;

            if (daysRemaining <= 3)
            {
                return $"Your license will expire in {daysRemaining} day(s) on {license.EndDate:yyyy-MM-dd}. Please renew it soon.";
            }

            return "";
        }
    }
}
