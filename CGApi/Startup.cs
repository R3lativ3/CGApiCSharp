using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CGApi.Common;
using CGApi.IServices;
using CGApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace CGApi
{
    public class Startup
    {
        private readonly string _Cors = "Cors";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            //DATABASE CONNECTION
            services.AddSingleton<IConfiguration>(Configuration);


            // DEFINIR DEPENDENCIA.
            services.AddScoped<IUsuarioDataService, UsuarioDataService>();
            services.AddScoped<IUsuariosDataService, UsuariosDataService>();

            Global.ConnectionString = Configuration.GetConnectionString("Development");


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CGApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CGApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(_Cors);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

