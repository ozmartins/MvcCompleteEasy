using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCompleteEasy.Models
{
    public class Address : Entity
    {
        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(200, ErrorMessage = "The field {0} must to have between {2} and {1} characters.", MinimumLength = 2)]
        public string Street { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(50, ErrorMessage = "The field {0} must to have between {2} and {1} characters.", MinimumLength = 2)]
        public string Number { get; set; }
        
        public string Complement { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(8, ErrorMessage = "The field {0} must to have {1} characters.", MinimumLength = 8)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(100, ErrorMessage = "The field {0} must to have between {2} and {1} characters.", MinimumLength = 2)]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(100, ErrorMessage = "The field {0} must to have between {2} and {1} characters.", MinimumLength = 2)]
        public string CityName { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(2, ErrorMessage = "The field {0} must to have between {2} and {1} characters.", MinimumLength = 2)]
        public string State { get; set; }
        
        public Guid SupplierId { get; set; }
        
        public Supplier Supplier { get; set; }

    }
}
