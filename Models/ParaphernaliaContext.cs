using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaphernaliaArchive.Models
{
    public class ParaphernaliaContext : DbContext
    {
        public ParaphernaliaContext(DbContextOptions<ParaphernaliaContext> options) : base(options) {}

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Item");
        }
    }
}
