using InvoiceMenagment.Api.DTOs.Request;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace InvoiceMenagment.Helper
{
    public static class LicenseGenerator
    {
        public static string GenerateLicense(LicenseRequest request)
        {
            var licenseData = new
            {
                request.ClientId,
                request.StartDate,
                request.EndDate,
                Hash = GenerateHash(request)
            };

            string json = JsonSerializer.Serialize(licenseData);
            return json;
        }

        private static string GenerateHash(LicenseRequest request)
        {
            var rawData = $"{request.ClientId}|{request.StartDate:yyyyMMdd}|{request.EndDate:yyyyMMdd}";
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(rawData);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }

}
