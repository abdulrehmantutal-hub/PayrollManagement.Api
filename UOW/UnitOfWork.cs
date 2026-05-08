using InvoiceMenagment.Api.Data;
using InvoiceMenagment.Api.Repositories;
using InvoiceMenagment.Api.Repositories.Interfaces;
using InvoiceMenagment.Api.Repository;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore; 
namespace InvoiceMenagment.Api.UOW
{
    public class UnitOfWork : IUnitOfWork
    {


        #region Private / ReadOnly Property Declare
        private readonly ApplicationDbContext _context;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IPageRepository _pageRepository;
        private readonly IPageControlRepository _pageControlRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IRoleControlPermissionRepository _roleControlPermissionRepository;
        private readonly IRolePagePermissionRepository _rolePagePermissionRepository;
        private readonly ILicenseRepository _licenseRepository;

        #endregion

        #region Public Getter Properties  
        public IApplicationUserRepository ApplicationUserRepository => _applicationUserRepository;
        //public IFunctionRepository FunctionRepository => _functionRepository;
        public IPageRepository PageRepository => _pageRepository;
        public IPageControlRepository PageControlRepository => _pageControlRepository;
        public IRoleRepository RoleRepository => _roleRepository;
        public IRolePagePermissionRepository RolePagePermissionRepository => _rolePagePermissionRepository;
        public IRoleControlPermissionRepository RoleControlPermissionRepository => _roleControlPermissionRepository;
        public ILicenseRepository LicenseRepository => _licenseRepository;


        #endregion

        #region Contrutor pass parameter and initial object using dependency injection
        public UnitOfWork(
            ApplicationDbContext context,
        IApplicationUserRepository applicationUserRepository,
        IPageRepository pageRepository,
        IPageControlRepository pageControlRepository,
        IRoleRepository roleRepository,
        IRolePagePermissionRepository rolePagePermissionRepository,
        IRoleControlPermissionRepository roleControlPermissionRepository,
        ILicenseRepository licenseRepository
          )
        {
            _context = context;
            _applicationUserRepository = applicationUserRepository;
            _pageRepository = pageRepository;
            _pageControlRepository = pageControlRepository;
            _roleRepository = roleRepository;
            _rolePagePermissionRepository = rolePagePermissionRepository;
            _roleControlPermissionRepository = roleControlPermissionRepository;
            _licenseRepository = licenseRepository;
            _repositories = new Dictionary<string, object>();
        }
        #endregion


        // Generic repositories cache
        private readonly Dictionary<string, object> _repositories;

        // Method to get the repository for a specific entity
        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            var entityType = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(entityType))
            {
                var repositoryType = typeof(GenericRepository<>).MakeGenericType(typeof(TEntity));
                var repositoryInstance = Activator.CreateInstance(repositoryType, _context);
                _repositories.Add(entityType, repositoryInstance);
            }

            return (IGenericRepository<TEntity>)_repositories[entityType];
        }


        public DbContext Context => _context; 
        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Database update failed. See inner exception for details.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while saving changes.", ex);
            }
        }


        public void Dispose()
        {
            _context.Dispose();
        }


        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }




    }
}
