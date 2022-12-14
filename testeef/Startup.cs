using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using testeef.Data;

namespace testeef
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
          Configuration = configuration;  
        }

        public IConfiguration Configuration{get;}


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext> (opt => opt.UseInMemoryDatabase("testeef"));
            services.AddScoped<DataContext, DataContext>();
            services.AddControllers();
        }
        

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseEndpoints(endpoints => 
            {
                endpoints.MapControllers();
            });
        }
    }
}