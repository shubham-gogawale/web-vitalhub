using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
//using web_vitalhub.Controllers;
using Microsoft.EntityFrameworkCore;
using Vitalhub.Services.ServiceContracts;
using Vitalhub.Services;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using StructureMap;
using Vitalhub.Web;
using Vitalhub.Store.MySqlStore;

namespace web_vitalhub
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {

            services.
               AddScoped<ICategoryService, CategoryService>()
               .AddDbContextPool<CategoryContext>(
                options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 11))))
              .AddMvc();
                //AddJsonOptions(options =>
                //{
                //    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                //    options.SerializerSettings.Converters.Add(new StringEnumConverter { CamelCaseText = true });
                //});

            //services.AddDbContextPool<StudentDetailContext> (
            //   options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 11)
            // )));
            var container = SetupContainer(services);
            var serviceProvider = container.GetInstance<IServiceProvider>();
            return serviceProvider;


        }
        private static Container SetupContainer(IServiceCollection services)
        {
            var container = new Container();
            container.Configure(config =>
            {
                config.AddRegistry<WebRegistry>();
                config.Populate(services);
            });

            return container;
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "web_vitalhub v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
