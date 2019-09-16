﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gl155914_MIS4200.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object

namespace gl155914_MIS4200.DAL
{
    public class MyContext : DbContext //inherits from DbContext
    {
        public MyContext() : base ("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        // Include each object here. The value inside <> is the name of the class
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}