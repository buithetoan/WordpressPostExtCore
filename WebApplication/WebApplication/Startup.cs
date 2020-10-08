using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtCore.Data.EntityFramework;
using ExtCore.WebApplication.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication
{
    public class Startup
    {
        private string extensionsPath;

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            this.Configuration = configuration;
            this.extensionsPath = webHostEnvironment.ContentRootPath + this.Configuration["Extensions:Path"];
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddExtCore(this.extensionsPath, this.Configuration["Extensions:IncludingSubpaths"] == true.ToString());
            services.Configure<StorageContextOptions>(options =>
            {
                options.ConnectionString = this.Configuration.GetConnectionString("Default");
            });
        }

        public void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment webHostEnvironment)
        {
            if (webHostEnvironment.IsDevelopment())
                applicationBuilder.UseDeveloperExceptionPage();

            applicationBuilder.UseExtCore();
        }
    }
}
