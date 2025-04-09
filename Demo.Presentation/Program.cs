using System;
using Demo.DataAccess.Contexts;
using Demo.DataAccess.Models;
using Demo.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Demo.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Add services to the container.

            // register service in di container
            builder.Services.AddControllersWithViews();

            // Register DbContext
            builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));




            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            #endregion

            var app = builder.Build();

            #region Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            #endregion

            app.Run();
        }
    }
}
