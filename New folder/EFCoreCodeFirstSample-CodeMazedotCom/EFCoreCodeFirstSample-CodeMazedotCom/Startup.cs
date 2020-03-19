
using EFCoreCodeFirstSample_CodeMazedotCom.Entities;
using EFCoreCodeFirstSample_CodeMazedotCom.Extensions;
using EFCoreCodeFirstSample_CodeMazedotCom.Models;
using EFCoreCodeFirstSample_CodeMazedotCom.Models.DataManager;
using EFCoreCodeFirstSample_CodeMazedotCom.Models.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace EFCoreCodeFirstSample_CodeMazedotCom
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
            services.ConfigureCore();
            services.ConfigureIISIntegration();

            services.AddDbContext<EmployeeContext>(opts =>
                opts.UseSqlServer(Configuration["ConnectionString:EmployeeDB"]));
            services.AddScoped<IDataRepository<Employee>, EmployeeManager>();


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseCors("CorsPolicy");

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
