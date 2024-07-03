using BlogProjectApp.DataAccess.Identity;
using BlogProjectApp.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.DataAccess.Contexts
{
    public class BlogDbContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options):base(options) { }

        public DbSet<Article > Articles { get; set; }
        public DbSet<Category> Category { get;set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //fluent Apı Validation
            builder.Entity<Article>().Property("Title").IsRequired().HasMaxLength(200);
            builder.Entity<Article>().Property("Summary").IsRequired().HasMaxLength(200);
            builder.Entity<Category>().Property("Name").IsRequired().HasMaxLength(100);
            builder.Entity<Tag>().Property("Content").IsRequired().HasMaxLength(20);
            builder.Entity<Comment>().Property("Content").IsRequired();

            //Seed Data

            builder.Entity<Category>().HasData(
                new Category() { Id=1,Name="C#.Net Core Programing",Description="C# .Net Introduction"},
				new Category() { Id = 2, Name = "Entity Framework Core", Description = "Entity Framework Core ile ORM Teknolojileri" },
				new Category() { Id = 3, Name = "Asp Net Core MVC", Description = "Asp Net Cıre Mvc ile Web Programcılığı" }
				);
            builder.Entity<Article>().HasData(
                new Article() { Id = 1, Title = "C# Net Core Introduction", Summary = "Visual Studio Net  ortamında C# Net Core ile temel seviyeden (veri türleri,değişkenler,if-else,dögüler,diziler)", Content = "Visual Studio Net  ortamında C# Net Core ile temel seviyeden (veri türleri,değişkenler,if-else,dögüler,diziler) ileri seviyeye(nesneye daalı programlama -opp,collections,generic collections,interfaces,linq) eğitim programı)", CategoryId = 1, UserId = 1, PictureUrl = "/images/7.jpg" },
                new Article() { Id = 2, Title = "Entity Framework Core ile Orm", Summary = "Visual studio.Net ortamında entity framework core ırn teknolojisini kullanarak veri tabanı varlılarının nesnel olarak yazılım tarafına atarılamsı ve yönetilmesi...", Content = "Visual studio.Net ortamında entity framework core ırn teknolojisini kullanarak veri tabanı varlılarının nesnel olarak yazılım tarafına atarılamsı ve yönetilmesi", CategoryId = 2, UserId = 2, PictureUrl = "/images/6.jpg" },
                new Article() { Id = 3, Title = "Asp Net Core mvc web programlama", Summary = "visual studio net ortamında asp.net core mvc ile temel düzeyden ileri seviyeye web programlama eğitimi,asp.net Restfull  APIs",Content= "visual studio net ortamında asp.net core mvc ile temel düzeyden ileri seviyeye web programlama eğitimi,asp.net Restfull  APIs...", CategoryId = 3, UserId = 1, PictureUrl = "/images/5.jpg" }
                );

			base.OnModelCreating(builder);
           
        }
    }
}
