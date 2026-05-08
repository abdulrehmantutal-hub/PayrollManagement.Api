using API_FMS_FlourManagementSystem.Core.Aspects.Logging;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Models.InvoiceMenagment.Api.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;

namespace InvoiceMenagment.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly AuditLoggingInterceptor _auditLoggingInterceptor;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, AuditLoggingInterceptor auditLoggingInterceptor)
            : base(options)
        {
            _auditLoggingInterceptor = auditLoggingInterceptor;
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_auditLoggingInterceptor);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<ApplicationUser> applicationUser { get; set; }
        public DbSet<SystemSetting> SystemSetting { get; set; }
        public DbSet<LookUpName> lookUpName { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Country> country { get; set; }
        public DbSet<Province> province { get; set; }
        public DbSet<District> district { get; set; }
        public DbSet<City> city { get; set; }
        public DbSet<Item> item { get; set; }
        public DbSet<Supplier> supplier { get; set; }

        public DbSet<ItemRate> itemRate { get; set; }
        public DbSet<ItemSubCategory> itemSubCategory { get; set; }
        public DbSet<ItemCategory> itemCategory { get; set; }

        public DbSet<SalePerson> salePerson { get; set; }
        public DbSet<SalePersonLoader> salePersonLoader { get; set; }
        public DbSet<SupervisorAssignSector> supervisorAssignSector { get; set; }
        public DbSet<SectorAssignSaleMen> sectorAssignSaleMen { get; set; }
        public DbSet<SectorSalePerson> sectorSalePerson { get; set; }
        public DbSet<Models.Page> page { get; set; }
        public DbSet<Role> role { get; set; }
        public DbSet<RolePagePermission> rolePagePermission { get; set; }
        public DbSet<RoleControlPermission> RoleControlPermissions { get; set; }
        public DbSet<Control> control { get; set; }
        public DbSet<Sale> sale { get; set; }
        public DbSet<SaleParameter> saleParameter { get; set; }
        public DbSet<SaleBillTypeParameter> saleBillTypeParameter { get; set; }
        public DbSet<LoaderParameter> loaderParameter { get; set; }
        public DbSet<LoaderParameterLoader> loaderParameterLoader { get; set; }
        public DbSet<SaleReturn> saleReturn { get; set; }
        public DbSet<SaleReturnParameter> saleReturnParameter { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseParameter> purchaseParameter { get; set; }
        public DbSet<PurchaseReturn> PurchaseReturn { get; set; }
        public DbSet<AuditLog> auditLog { get; set; }
        public DbSet<PurchaseReturnParameter> purchaseReturnParameter { get; set; }
        public DbSet<SaleDashboard> saleDashboard { get; set; }
        public DbSet<CompanySetup> companySetup { get; set; }
        public DbSet<GatePassNumber> gatePassNumber { get; set; }

        public DbSet<AccountDetail> accountDetail { get; set; }
        public DbSet<AccountGroup> accountGroup { get; set; }
        public DbSet<AccountSubGroup> accountSubGroup { get; set; }
        public DbSet<AccountDetailTypeParameter> accountDetailTypeParameter { get; set; }
        public DbSet<GeneralLedger> generalLedgers { get; set; }
        public DbSet<GeneralLedgerParameters> generalLedgerParameters { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookParameter> BookParameter { get; set; }
        public DbSet<BookType> BookType { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<GlobalAccount> GlobalAccount { get; set; }
        public DbSet<Cheque> Cheque { get; set; }

        public DbSet<Client> Client { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<LicenseLog> LicenseLog { get; set; }
        public DbSet<StockConfig> StockConfigs { get; set; }
        public DbSet<StockConfigrationMaster> StockConfigMaster { get; set; }

        public DbSet<Stock> Stock { get; set; }
        public DbSet<StockParameters> StockParameters { get; set; }
        public DbSet<StockAdjustment> StockAdjustment { get; set; }
        public DbSet<StockAdjustmentParameter> StockAdjustmentParameter { get; set; }
        public DbSet<GatePassAudit> gatepass_audit { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
