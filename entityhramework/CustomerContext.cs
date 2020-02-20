using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace entityhramework
{
    class CustomerContext:DbContext
    {
        public CustomerContext() : base("CustomerContext") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModeCreating(DbModeBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
