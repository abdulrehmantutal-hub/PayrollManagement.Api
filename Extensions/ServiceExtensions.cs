using API_FMS_FlourManagementSystem.Core.Aspects.Logging;
using InvoiceMenagment.Api.CustomMiddlewares;
using InvoiceMenagment.Api.Mapping;
using InvoiceMenagment.Api.Repositories;
using InvoiceMenagment.Api.Repositories.Interfaces;
using InvoiceMenagment.Api.Repository;
using InvoiceMenagment.Api.Services;
using InvoiceMenagment.Api.Services.Interfaces;
using InvoiceMenagment.Api.UOW;
using Minio;

namespace InvoiceMenagment.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterAllDependencies(this IServiceCollection services)
        {
            // Call individual registration methods
            services.RegisterRepositories();
            services.RegisterServices();
            services.RegisterCoreServices();

            return services;
        }

        // Register Repositories
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        { 
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddScoped<IRolePagePermissionRepository, RolePagePermissionRepository>();
            services.AddScoped<IRolePagePermissionRepository, RolePagePermissionRepository>();
            services.AddScoped<IPageRepository, PageRepository>();
            services.AddScoped<IPageControlRepository, PageControlRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IRoleControlPermissionRepository, RoleControlPermissionRepository>();
            services.AddScoped<ILicenseRepository, LicenseRepository>();
            return services;
        }

        // Register Services
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IApplicationUserService, ApplicationUserService>();
            //services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IPagePermissionService, PagePermissionService>();
            services.AddScoped<IPageService, PageService>();
            services.AddScoped<IPageControlService, PageControlService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ILicenseService, LicenseService>();
            return services;
        }

        // Register Core Services
        public static IServiceCollection RegisterCoreServices(this IServiceCollection services)
        {

            //UnitofWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(Program));
            services.AddHttpContextAccessor();
              
            //
            services.AddScoped<AuditLoggingInterceptor>();  //  
            services.AddAutoMapper(typeof(MappingProfile));
           
            //Add Minio
            services.AddSingleton<IMinioClient>(sp =>
            {
                var config = sp.GetRequiredService<IConfiguration>();
                var accessKey = config["Minio:AccessKey"];
                var secretKey = config["Minio:SecretKey"];
                var endpoint = config["Minio:Endpoint"];

                return new MinioClient()
                    .WithEndpoint(endpoint)
                    .WithCredentials(accessKey, secretKey)
                    .WithSSL()
                    .Build();
            });



            return services;
        }
         
        // Register middleware
        public static IApplicationBuilder UseCustomMiddlewares(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlingMiddleware>();
            app.UseMiddleware<LicenseMiddleware>();
            return app;
        }

    }
}
