using Microsoft.AspNetCore.DataProtection.Internal;

namespace InvoiceMenagment.Api.Models.Interfaces
{
    public interface IBasicEntity : IActivate, IDelete, IAudit
    {
    }
}
