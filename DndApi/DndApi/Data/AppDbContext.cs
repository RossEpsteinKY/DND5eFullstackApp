using DndApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DndApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=dnd_db;Username=postgres;Password=root");
        }

        public DbSet<CreatedCharacterModel> created_characters { get; set; }

  
    }
}

