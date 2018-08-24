using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatteStand.Domain.Models;


namespace LatteStand.Data.Maps
{
    class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
        

    }
}
