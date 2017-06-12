using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RubenVanWee.TestData.Entities;

namespace RubenVanWee.TestData
{
    public class EntityContext : IdentityDbContext<UserEntity>
    {
        public DbSet<UserEntity> Configurations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = "Filename=./Identity.db";
            optionsBuilder.UseSqlite(path);
        }
    }
}