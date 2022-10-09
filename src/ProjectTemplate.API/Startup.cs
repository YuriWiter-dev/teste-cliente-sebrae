using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectTemplate.Application.Mappings;
using ProjectTemplate.Infra.Data.Contexto;
using ProjectTemplate.Infra.IoC;
using Microsoft.OpenApi.Models;
using System;

namespace ProjectTemplate.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkSqlServer()
              .AddDbContext<BaseContexto>(
                  options => options.UseSqlServer(
                      Configuration.GetConnectionString("BaseDatabase")));

            InjectorDependencies.Registrer(services);
            services.AddAutoMapper(x => x.AddProfile(new BaseMapping()));
            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "API",
                    Description = "",
                    Contact = new OpenApiContact
                    {
                        Name = "Controle Clientes",
                        Email = string.Empty
                    }
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
