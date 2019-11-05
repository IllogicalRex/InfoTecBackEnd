
using InfoTecBackEnd.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Builder;
using InfoTecBackEnd.Handlers;

namespace InfoTecBackEnd
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
            services.AddDbContext<ResourceDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("InfoTecDataBase")));
            services.AddMediatR(typeof(ProjectBankHandler).Assembly);
            services.AddMediatR(typeof(GetAllProjectBankHandler).Assembly);
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                // app.UseHsts();
            }

           // app.UseHttpsRedirection();
           // app.UseMvc();
           app.UseMvc();
           /*  app.UseMvc(builder =>
            {
                builder.Select().Expand().Filter().OrderBy().Count().MaxTop(100);
                builder.MapVersionedODataRoutes("odata", "odata", modelBuilder.GetEdmModels());
            }); */
        }
    }
}
