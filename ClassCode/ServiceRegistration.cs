using ClassCode.DAL;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClassCode
{
    public static class ServiceRegistration
    {
        public static void Register(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllersWithViews();
            //services.AddDbContext<AppDbContext>(options =>
            //{
            //    options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            //});
     

        }
    }
}
