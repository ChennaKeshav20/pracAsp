using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pracAsp.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("MyConn")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers{ get; set; }

    }
}