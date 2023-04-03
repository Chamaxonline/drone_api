using SmartERP.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;
using Entity.Context;
using SmartERP.Repository.Implementation;
using SmartERP.Repository.Interfaces;
using AutoMapper;
using Entity.Models;
namespace SmartERP.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRepository();
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins("http://localhost", "http://localhost:4200", "http://localhost:3000")
                                        .AllowAnyHeader()
                                .AllowAnyMethod();
                });
            });

            //services.AddTransient<IVehicleConditionRepository, VehicleConditionRepository>();
            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));

           
            services.AddDbContext<SmartDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("carDbConnect")));

            services.AddControllers();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);         



            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Logistic ERP API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Logistic ERP API");
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
