using Autofac;
using AutoMapper;
using ISProject.DAL;
using ISProject.DAL.Entities;
using ISProject.Repository;
using ISProject.Service;
using ISProject.WebApi.Settings;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace ISProject.WebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlServer(this IServiceCollection services, IConfiguration configuration)
        {
            var migrationAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;
            var dbConnections = new ConnectionStrings();

            configuration.Bind("ConnectionStrings", dbConnections);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(dbConnections.ISProjectDB,
                    sqlOptions => sqlOptions.MigrationsAssembly(migrationAssembly)));
        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services
                .AddIdentity<UserEntity, IdentityRole<Guid>>(opt =>
                {
                    opt.Password.RequiredLength = 7;
                    opt.Password.RequireDigit = false;
                    opt.Password.RequireUppercase = false;

                    opt.User.RequireUniqueEmail = true;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>();
        }
        public static void ConfigureIdentityServer(this IServiceCollection services, IConfiguration configuration)
        {
            var migrationAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;
            var dbConnections = new ConnectionStrings();

            configuration.Bind("ConnectionStrings", dbConnections);

            services
                .AddIdentityServer(options =>
                {
                    options.UserInteraction.LoginUrl = "http://localhost/4200/auth/login";
                })
                .AddAspNetIdentity<UserEntity>()
                .AddConfigurationStore(opt =>
                {
                    opt.ConfigureDbContext = c => c.UseSqlServer(dbConnections.ISProjectDB,
                        opt => opt.MigrationsAssembly(migrationAssembly));
                })
                .AddOperationalStore(opt =>
                {
                    opt.ConfigureDbContext = o => o.UseSqlServer(dbConnections.ISProjectDB,
                        opt => opt.MigrationsAssembly(migrationAssembly));
                })
                .AddDeveloperSigningCredential();

        }
        public static void ConfigureAutoFac(this ContainerBuilder builder)
        {
            builder.RegisterModule<ServiceDIModule>();
            builder.RegisterModule<RepositoryDIModule>();
        }
        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new Action<IMapperConfigurationExpression>(options =>
            {
                options.AddMaps("ISProject.Common");
            });

            services.AddAutoMapper(mapperConfig);
        }
    }
}
