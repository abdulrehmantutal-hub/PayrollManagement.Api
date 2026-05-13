    using API_FMS_FlourManagementSystem.Core.Aspects.Logging;
using API_FMS_FlourManagementSystem.Models;
using InvoiceMenagment.Api.DTOs.Response;
    using InvoiceMenagment.Api.Models;
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
            public DbSet<Models.Page> page { get; set; }
            public DbSet<Role> role { get; set; }
            public DbSet<RolePagePermission> rolePagePermission { get; set; }
            public DbSet<RoleControlPermission> RoleControlPermissions { get; set; }
            public DbSet<Control> control { get; set; }
            public DbSet<AuditLog> auditLog { get; set; }
            public DbSet<CompanySetup> companySetup { get; set; }
            public DbSet<Subscription> Subscriptions { get; set; }
            public DbSet<Client> Client { get; set; }
            public DbSet<LicenseLog> LicenseLog { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }
        }
    }
