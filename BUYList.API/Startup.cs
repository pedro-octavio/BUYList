using Autofac;
using AutoMapper;
using BUYList.Application.Mappers;
using BUYList.Infra.Data;
using BUYList.Infra.IOC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BUYList.API
{
    public class Startup
    {
        public Startup
        (IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices
        (IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<DataContext>(options => options.UseMySql(Configuration["ConnectionStrings:BUYList"], x => x.MigrationsAssembly("BUYList.API")));

            services.AddAutoMapper(typeof(MappingProfile));
        }

        public void ConfigureContainer
        (ContainerBuilder builder) => builder.RegisterModule(new ModuleIOC());

        public void Configure
        (IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
