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
            base.OnModelCreating(builder);
            //Seed Data
        }
    }
}
