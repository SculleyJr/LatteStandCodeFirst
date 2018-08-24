using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatteStand.Domain.Models;

namespace LatteStand.Data
{
    class LatteStandInitializer : CreateDatabaseIfNotExists<LatteStandContext>
    {
        protected override void Seed(LatteStandContext context)
        {
            var customer = new Customer()
            {
                Id = 1,
                Name = "Sean",
                LastName = "Sculley",
                Email = "sculley90@gmai.com",
                Phone = "616-747-1688"

            };
            context.Customers.Add(customer);

            base.Seed(context);
        }
    }
}
