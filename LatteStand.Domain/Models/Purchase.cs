using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatteStand.Domain.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public ICollection<Product> Products { get; set; }

        public Customer Customer { get; set; }


    }
}
