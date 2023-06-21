using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public ICollection<Customer>? Customers { get; set; }
    }
}
