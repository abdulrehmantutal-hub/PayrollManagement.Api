using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using InvoiceMenagment.Api.Repositories.Interfaces;
using InvoiceMenagment.Api.Repository;

namespace InvoiceMenagment.Api.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; } 
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
        IApplicationUserRepository ApplicationUserRepository { get; }
        IPageRepository PageRepository { get; }
        IPageControlRepository PageControlRepository { get; }
        IRoleRepository RoleRepository { get; }
        IRolePagePermissionRepository RolePagePermissionRepository { get; }
        ILicenseRepository LicenseRepository { get; }
    }
}
