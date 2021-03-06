using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using condominio_core_api.Entity;
using condominio_core_api.Repository.Context;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;
using condominio_core_api.Repository.Implementation;
using condominio_core_api.Repository;
using condominio_core_api.Service;
using condominio_core_api.Service.Implementation;

namespace condominio_core_api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDbContext>(opt =>
            opt.UseNpgsql (Configuration.GetConnectionString ("DefaultConnection")));*/
            services.AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                }
                );

            services.AddControllers();
            services.AddTransient<ICompanyServicesRepository,CompanyServicesRepository>();
            services.AddTransient<ICompanyServicesService, CompanyServicesService>();
            services.AddTransient <ICompanyRepository,CompanyRepository>();
            services.AddTransient <ICompanyService, Service.Implementation.CompanyService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IProjectFileRepository, ProjectFileRepository>();
            services.AddTransient<IProjectFileService, ProjectFileService>();
            services.AddTransient<IApartmentRepository, ApartmentRepository>();
            services.AddTransient<IApartmentService, ApartmentService>();
            services.AddTransient<IApartmentFileRepository, ApartmentFileRepository>();
            services.AddTransient<IApartmentFileService, ApartmentFileService>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IPersonService, PersonService>();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Condominio API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                
            });




            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
