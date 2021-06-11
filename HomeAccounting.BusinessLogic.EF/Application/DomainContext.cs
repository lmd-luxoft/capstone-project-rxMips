using System;
using System.Collections.Generic;
using System.Text;
using HomeAccounting.DataSource.EF.Domain;
using Microsoft.EntityFrameworkCore;

namespace HomeAccounting.DataSource.EF.Application
{
    public class DomainContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Cash> Cashes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyPriceChange> PriceChanges { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
    }
}