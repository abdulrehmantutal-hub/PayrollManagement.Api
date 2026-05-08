

using InvoiceMenagment.Api.Models;

namespace InvoiceMenagment.Api.Services.Interfaces
{
    public interface ILicenseService
    {
        LicenseModel? LoadLicense();
        bool IsLicenseValid();

        string GetLicenseStatusMessage();
    }
}
