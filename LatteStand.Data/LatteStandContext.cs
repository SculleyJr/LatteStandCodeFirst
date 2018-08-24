using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatteStand.Data.Maps;
using LatteStand.Domain.Models;

namespace LatteStand.Data
{
    public class LatteStandContext : DbContext
    {
        public LatteStandContext() :base("LatteStand")
        {
            Database.SetInitializer(new LatteStandInitializer());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new ProductMap());
           
            base.OnModelCreating(modelBuilder);

        }
    }
}
