﻿using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Database
{
    public class EntitiesContext : DbContext
    {
        #region Attributes
        private DbSet<Bicycle> bicycles;
        private DbSet<Customer> customers;
        private DbSet<Seller> sellers;
        private DbSet<Order> orders;
        #endregion

        #region Properties
        public DbSet<Bicycle> Bicycles
        {
            get { return bicycles; }
            set { bicycles = value; }
        }

        public DbSet<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }

        public DbSet<Seller> Sellers
        {
            get { return sellers; }
            set { sellers = value; }
        }

        public DbSet<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        #endregion

        #region Constructors
        public EntitiesContext() : base()
        {
            try
            {
                if (this.Database.CreateIfNotExists())
                {
                    // Implémentation de la db Bicycles
                    for (int i = 1; i < 5; i++)
                    {
                        Bicycle bicycle = new Bicycle();
                        bicycle.TypeOfBike = "";
                        bicycle.Exchangeable = true;
                        bicycle.Insurance = true;
                        bicycle.Deliverable = true;
                        bicycle.Category = "";
                        bicycle.Size = 1.75F +i*0.01F;
                        bicycle.Weight = 11.5F +i*0.5F;
                        bicycle.Color = "";
                        bicycle.Confort = "";
                        bicycle.FreeTaxPrice = 2000F-i*100;
                        bicycle.Electric = true;
                        bicycle.State = "";
                        bicycle.Brand = "";
                        this.Bicycles.Add(bicycle);
                        this.SaveChanges();
                    }

                    // Implémentation de la db Sellers
                    for (int i = 1; i < 5; i++)
                    {
                        Seller Seller = new Seller();
                        Seller.Category = "seller"+i;
                        Seller.FirstName = "firstName"+i;
                        Seller.LastName = "lastName"+i;
                        Seller.Password = "password"+i;
                        this.Sellers.Add(Seller);
                        this.SaveChanges();
                    }

                    // Implémentation de la Db customers
                    for (int i = 1; i < 5; i++)
                    {
                        Customer customer = new Customer();
                        customer.Address = "adress"+i;
                        customer.Email = "email"+i;
                        customer.FirstName = "firstname"+i;
                        customer.LastName = "lastname"+i;
                        customer.LoyaltyPoints = 0;
                        customer.Orders = null;
                        customer.Phone = "+33..."+i;
                        customer.PostalCode = 35000;
                        customer.Town = "rennes";
                        this.Customers.Add(customer);
                        this.SaveChanges();
                    }

                    //Instanciation
                    Shop shop1 = new Shop();

                    // Implémentation de la db Orders 
                    for (int i = 1; i < 5; i++)
                    {
                        Seller seller1 = new Seller();
                        Payment payMode1 = new Payment();
                        Customer customer1 = new Customer();

                        Order order = new Order();
                        order.Date = DateTime.Now;
                        order.Discount = 0.1F;
                        order.Seller = seller1;
                        order.Customer = customer1;
                        order.Shop = shop1;
                        order.LoyaltyPoint = 5 + i;
                        order.LoyaltyPointUsed = 0;
                        order.LoyaltyPointEarned = 0;
                        order.TotalLoyaltyPoint = order.LoyaltyPointCalculated();
                        order.Quantity = 1 + i; // comment lier quantity et Bicycle
                        order.SumFreeTax = order.SumFreeTaxCalculated();
                        order.Tax = 0.2F;
                        order.ShippingCost = 0;
                        order.PayMode = payMode1;
                        order.TotalAmount = order.TotalAmountCalculated();
                        this.Orders.Add(order);
                        this.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region functions
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Order>().HasMany<Bicycle>(o => o.Bicycles).WithMany(b => b.Orders);
        //    modelBuilder.Entity<Order>().HasRequired<Seller>(o => o.Seller).WithMany(s => s.Orders);
        //    modelBuilder.Entity<Order>().HasRequired<Customer>(o => o.Customer).WithMany(c => c.Orders);

        //    base.OnModelCreating(modelBuilder);
        //}
        #endregion

    }
}

