using EMagazine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMagazine.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) //конструктор 
                    : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SellerCustomers> SellersCustomers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Nurlan",
                    Surname = "Eyvazov"
                }
                );
            modelBuilder.Entity<Seller>().HasData(
                new Seller
                {
                    Id = 1,
                    Name = "Kamran",
                    Surname = "Atayev",
                }
                );
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    FullName = "Mercedes S63",
                    Year = 2023,
                    Price = 500.000,
                    SellerId = 1
                }
                );
            modelBuilder.Entity<SellerCustomers>().HasData(
                new SellerCustomers
                {
                    SellerId = 1,
                    CustomerId = 1
                }
                );

            modelBuilder.Entity<Car>()
                .HasOne<Seller>(s => s.Seller)
                .WithMany(c => c.Cars)
                .HasForeignKey(fk => fk.SellerId);


            modelBuilder.Entity<SellerCustomers>().HasKey(sc => new { sc.SellerId, sc.CustomerId });

            modelBuilder.Entity<SellerCustomers>()
                .HasOne<Seller>(sc => sc.Seller)
                .WithMany(s => s.SellerCustomers)
                .HasForeignKey(sc => sc.SellerId);

            modelBuilder.Entity<SellerCustomers>()
                .HasOne<Customer>(sc => sc.Customer)
                .WithMany(s => s.SellerCustomers)
                .HasForeignKey(sc => sc.CustomerId);

        }

    }
}
