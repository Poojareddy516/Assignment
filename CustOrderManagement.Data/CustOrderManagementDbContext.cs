using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustOrderManagement.Data.Model;
using CustOrderManagement.Data.Extensions;

namespace CustOrderManagement.Data
{
    public class CustOrderManagementDbContext : DbContext
    {
        private static bool _created = false; // make this false to setup database schema and seed data
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public CustOrderManagementDbContext(DbContextOptions<CustOrderManagementDbContext> options) : base(options)
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();

            } }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        //{
        //    optionbuilder.UseSqlite(@"Data Source=..\CoreCrudApi.Db\Database\Employee.db");
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // On Model Creating - multitenancy query filters 

            modelBuilder.Entity<Customer>(e => {
                e.HasKey(nameof(Customer.CustomerId));
                e.Property(x => x.CustomerId).ValueGeneratedOnAdd();
                e.Property(x => x.CustomerName).IsRequired(true);
                e.Property(x => x.AddressLine1).IsRequired(false);
                e.Property(x => x.AddressLine2).IsRequired(false);
                e.Property(x => x.City).IsRequired(false);
                e.Property(x => x.State).IsRequired(false);
                e.Property(x => x.Zip).IsRequired(false);
                e.Property(x => x.Country).IsRequired(false);
            });

            modelBuilder.Entity<Product>(e => {
                e.HasKey(nameof(Product.ProductId));
                e.Property(x => x.ProductName).IsRequired(true);
                e.Property(x => x.PricedPerItem).IsRequired(true);
                e.Property(x => x.AverageCustomerRating).IsRequired(true);
            });

            modelBuilder.Entity<Order>(e => {
                e.HasKey(nameof(Order.OrderId));
                e.Property(x => x.CustomerId).IsRequired(true);
                e.Property(x => x.ProductId).IsRequired(true);
                e.Property(x => x.OrderDate).IsRequired(true);
            });

            modelBuilder.Seed();
        }

    }
}
