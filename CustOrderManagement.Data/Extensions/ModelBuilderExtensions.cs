using CustOrderManagement.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CustOrderManagement.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer[]
            {
                new Customer {CustomerId = 1,CustomerName="Smith John",AddressLine1="23 st",AddressLine2="apt 10",City="Atlanta",State="GA",Zip="12345",Country="India"},
                new Customer {CustomerId = 2,CustomerName="Mic John",AddressLine1="23 st",AddressLine2="apt 10",City="Atlanta",State="GA",Zip="12345",Country="India"},
                new Customer {CustomerId = 3,CustomerName="Marry John",AddressLine1="23 st",AddressLine2="apt 10",City="Atlanta",State="GA",Zip="12345",Country="India"},
                new Customer {CustomerId = 4,CustomerName="Jay John",AddressLine1="23 st",AddressLine2="apt 10",City="Atlanta",State="GA",Zip="12345",Country="India"},
                new Customer {CustomerId = 5,CustomerName="Anita John",AddressLine1="23 st",AddressLine2="apt 10",City="Atlanta",State="GA",Zip="12345",Country="India"},
                new Customer {CustomerId = 6,CustomerName="Ricks John",AddressLine1="23 st",AddressLine2="apt 10",City="Atlanta",State="GA",Zip="12345",Country="India"},
                new Customer {CustomerId = 7,CustomerName="Alex John",AddressLine1="23 st",AddressLine2="apt 10",City="Atlanta",State="GA",Zip="12345",Country="India"},
                new Customer {CustomerId = 8,CustomerName="Ori John",AddressLine1="23 st",AddressLine2="apt 10",City="Atlanta",State="GA",Zip="12345",Country="India"},
                new Customer {CustomerId = 9,CustomerName="Mike John",AddressLine1="23 st",AddressLine2="apt 10",City="Atlanta",State="GA",Zip="12345",Country="India"},
                new Customer {CustomerId = 10,CustomerName="Will John",AddressLine1="23 st",AddressLine2="apt 10",City="Atlanta",State="GA",Zip="12345",Country="India"},

            });

            modelBuilder.Entity<Product>().HasData(new Product[] {
                new Product { ProductId=1,ProductName="Apple Airpod", PricedPerItem=200, AverageCustomerRating=5 },
                new Product { ProductId=2,ProductName="Apple IPhone 15", PricedPerItem=200, AverageCustomerRating=3 },
                new Product { ProductId=3,ProductName="Apple Watch Series 9", PricedPerItem=200, AverageCustomerRating=4 },
                new Product { ProductId=4,ProductName="Apple Watch Ultra 3", PricedPerItem=200, AverageCustomerRating=5 },
                new Product { ProductId=5,ProductName="Apple IPhone 14", PricedPerItem=200, AverageCustomerRating=5 },
                new Product { ProductId=6,ProductName="Apple Tags", PricedPerItem=200, AverageCustomerRating=1 },
                new Product { ProductId=7,ProductName="Samsung S23", PricedPerItem=200, AverageCustomerRating=4 },
                new Product { ProductId=8,ProductName="Motorola G5", PricedPerItem=200, AverageCustomerRating=3 },
            });

            modelBuilder.Entity<Order>().HasData(new Order[] {
                new Order { OrderId=123, CustomerId=1, ProductId=1, Quantity=10, PricePaid=100,ShippedDate=DateTime.Now.AddDays(7), OrderDate=DateTime.Now},
                new Order { OrderId=124, CustomerId=1, ProductId=2, Quantity=5, PricePaid=100,ShippedDate=DateTime.Now.AddDays(7), OrderDate=DateTime.Now},
                new Order { OrderId=125, CustomerId=1, ProductId=3, Quantity=4, PricePaid=100,ShippedDate=DateTime.Now.AddDays(7), OrderDate=DateTime.Now},
                new Order { OrderId=126, CustomerId=2, ProductId=4, Quantity=2, PricePaid=100,ShippedDate=DateTime.Now.AddDays(7), OrderDate=DateTime.Now},
                new Order { OrderId=127, CustomerId=2, ProductId=5, Quantity=1, PricePaid=100,ShippedDate=DateTime.Now.AddDays(7), OrderDate=DateTime.Now},
                new Order { OrderId=128, CustomerId=3, ProductId=1, Quantity=10, PricePaid=100,ShippedDate=DateTime.Now.AddDays(7), OrderDate=DateTime.Now},
                new Order { OrderId=129, CustomerId=4, ProductId=2, Quantity=5, PricePaid=100,ShippedDate=DateTime.Now.AddDays(7), OrderDate=DateTime.Now},
                new Order { OrderId=130, CustomerId=4, ProductId=3, Quantity=4, PricePaid=100,ShippedDate=DateTime.Now.AddDays(7), OrderDate=DateTime.Now},
                new Order { OrderId=131, CustomerId=5, ProductId=4, Quantity=2, PricePaid=100,ShippedDate=DateTime.Now.AddDays(7), OrderDate=DateTime.Now},
                new Order { OrderId=132, CustomerId=5, ProductId=5, Quantity=1, PricePaid=100,ShippedDate=DateTime.Now.AddDays(7), OrderDate=DateTime.Now},
            });
        }
    }
}
