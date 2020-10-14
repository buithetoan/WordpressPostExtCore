using ExtCore.Data.Abstractions;
using ExtCore.Infrastructure.Actions;
using Extension.Data.Entities.Models;
using Extension.Data.EntityFramework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Extension.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => 1000;
        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
            .SetBasePath(serviceProvider.GetService<IWebHostEnvironment>().ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySQL(configurationBuilder.Build().GetConnectionString("Default")));

            serviceCollection.AddIdentity<ApplicationUser, ApplicationRole>()
              .AddEntityFrameworkStores<ApplicationDbContext>()
              .AddDefaultTokenProviders();

            serviceCollection.AddScoped(typeof(IStorageContext), typeof(ApplicationDbContext));
        }
    }
}
