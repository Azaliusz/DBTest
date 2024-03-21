using DBTest.Data.ModelConfiguration;
using DBTest.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace DBTest.Data
{
    internal class TestContext : DbContext
    {
        public DbSet<SampleType> SampleType { get; set; }

        public DbSet<Sample> Sample { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost:5432;Database=test;Username=postgres;Password=test");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new SampleEntityTypeConfiguration().Configure(modelBuilder.Entity<Sample>());
            new SampleTypeEntityTypeConfiguration().Configure(modelBuilder.Entity<SampleType>());
        }
    }
}