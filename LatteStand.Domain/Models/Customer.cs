using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace LatteStand.Domain.Models
{
    public class Customer
    {
        public int Id { get; set; } 

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }


        [Required]
        public string Phone { get; set; }


    }
}
