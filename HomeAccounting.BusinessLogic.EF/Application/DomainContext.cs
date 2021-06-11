using System;
using System.Collections.Generic;
using System.Text;
using HomeAccounting.DataSource.EF.Domain;
using Microsoft.EntityFrameworkCore;

namespace HomeAccounting.DataSource.EF.Application
{
    public class DomainContext : DbContext
    {
        private const string ConnectionString = "Host=localhost; Username=postgres; Password=1; Database=Demo";

        // public DomainContext()
        // {
        //     //Database.EnsureDeleted();
        // }
        
        public DomainContext(DbContextOptions<DomainContext> options) : base(options)
        {
        }
        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Cash> Cashes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyPriceChange> PriceChanges { get; set; }
        public DbSet<Deposit> Deposits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>();
            modelBuilder.Entity<Bank>();
            modelBuilder.Entity<Cash>();
            var operations = modelBuilder.Entity<Operation>();
            operations.HasMany<Account>(x => x.Accounts);
            modelBuilder.Entity<Property>();
            modelBuilder.Entity<PropertyPriceChange>();
            modelBuilder.Entity<Deposit>();

        }
    }
}