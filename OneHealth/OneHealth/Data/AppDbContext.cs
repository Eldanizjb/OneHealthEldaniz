using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OneHealth.Models;

namespace OneHealth.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Aplication> Aplication { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<CustomUser> CustomUser { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsCategory> NewsCategory { get; set; }
        public DbSet<Paraqraph> Paraqraph { get; set; }
        public DbSet<Partner> Partner { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Sosial> Sosial { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<TagToNews> TagToNews { get; set; }
        public DbSet<TypePosition> TypePosition { get; set; }

    }
}
