using Aula2TrilhaDotNet.Adapter;
using Aula2TrilhaDotNet.Bordas.Adapter;
using Aula2TrilhaDotNet.Context;
using Aula2TrilhaDotNet.Repositorio;
using Aula2TrilhaDotNet.Services;
using Aula2TrilhaDotNet.UseCase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDbContext>(opt => opt.UseNpgsql
            (Configuration.GetConnectionString("urlTrilhaDotNet")));

            services.AddScoped<ISerraCircularService, SerraCircularService>();

            services.AddScoped<IAdicionarSerraCircularUseCase, AdicionarSerraCircularUseCase>();
            services.AddScoped<IAtulaizarSerraCircularUseCase, AtulaizarSerraCircularUseCase>();
            services.AddScoped<IRemoverSerraCircularUseCase, RemoverSerraCircularUseCase>();
            services.AddScoped<IRetornarListaSerraCircularUseCase, RetornarListaSerraCircularUseCase>();
            services.AddScoped<IRetornarSerraCircularIdUseCase, RetornarSerraCircularIdUseCase>();
            
            services.AddScoped<IRepositorioSerraCircular, RepositorioSerraCircular>();
          
            services.AddScoped<IAdicionarSerraCircularAdapter, AdicionarSerraCircularAdapter>();
            services.AddScoped<IAtualizarSerraCircularAdapter, AtualizarSerraCircularAdapter>();

            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
