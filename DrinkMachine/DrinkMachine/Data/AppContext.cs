using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DrinkMachine.Data
{
    public class AppContext : DbContext
    {
        public AppContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drink>().HasKey(k => k.Id).HasName("DrinkID");
            modelBuilder.Entity<Additive>().HasKey(k => k.Id).HasName("AdditiveID");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DrinkMachineDb"].ConnectionString);
        }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Additive> Additives { get; set; }
    }
}
