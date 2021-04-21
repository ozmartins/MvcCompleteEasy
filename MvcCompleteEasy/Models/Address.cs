using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCompleteEasy.Models
{
    public class Address : Entity
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
        public string Neighborhood { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
