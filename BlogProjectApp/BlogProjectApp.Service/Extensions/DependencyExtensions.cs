using BlogProjectApp.DataAccess.Contexts;
using BlogProjectApp.DataAccess.Identity;
using BlogProjectApp.DataAccess.Repositories;
using BlogProjectApp.DataAccess.UnitOfWorks;
using BlogProjectApp.Entity.Entities;
using BlogProjectApp.Entity.Repositories;
using BlogProjectApp.Entity.Services;
using BlogProjectApp.Entity.UnitOfWorks;
using BlogProjectApp.Service.Mapping;
using BlogProjectApp.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.Service.Extensions
{
    public static class DependencyExtensions
    {
        public static void AddExtensions(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(
                opt =>
                {
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequiredLength = 3;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireUppercase = false;
                    opt.Password.RequireDigit = false;

                    opt.User.RequireUniqueEmail = true; //aynı email adresinin girilmesine izin vermez
                    //opt.User.AllowedUserNameCharacters = "abcdefghijklmnoprstuvyzqw0123456789";

                    opt.Lockout.MaxFailedAccessAttempts = 3; //default=5
                    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
                }
                ).AddEntityFrameworkStores<BlogDbContext>();
            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = new PathString("/Account/Login");
                opt.LogoutPath = new PathString("/Account/Logout");
                //opt.AccessDeniedPath = new PathString("/Account/AccesDenied");
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                opt.SlidingExpiration = true;

                opt.Cookie = new CookieBuilder()
                {
                    Name = "Identity.App.Cookie",
                    HttpOnly = true
                };
            });
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IArticleService,ArticleService>();
            services.AddScoped<ICategoryService,CategoryService>();


            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
