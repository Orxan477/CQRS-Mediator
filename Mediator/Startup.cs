using Business.Med.Queries;
using Data.DAL;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySql.Data.MySqlClient;
using System;

namespace Mediator
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
            services.AddControllers();
            services.AddMediatR(typeof(GetAllProductQuery));
            #region MSSQL
            // services.AddDbContext<AppDbContext>(options =>
            // {
            //    options.UseSqlServer(Configuration["ConnectionStrings:Default"]);
            // });
            #endregion

            #region MySql
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = Configuration["ConnectionStrings:Default"];
            cnn = new MySqlConnection(connetionString);
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseMySQL(cnn);
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // app.UseHttpsRedirection();
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
