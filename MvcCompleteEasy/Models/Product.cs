using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCompleteEasy.Models
{
    public class Product : Entity
    {
        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(200, ErrorMessage = "The field {0} must to have between {2} and {1} characters.", MinimumLength = 2)]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(1000, ErrorMessage = "The field {0} must to have between {2} and {1} characters.", MinimumLength = 2)]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(500, ErrorMessage = "The field {0} must to have between {2} and {1} characters.", MinimumLength = 2)]
        public string Image { get; set; }
        
        [Required(ErrorMessage = "The field {0} is mandatory")]
        public decimal Price { get; set; }
        
        public DateTime CreationDate { get; set; }
        
        public bool Active { get; set; }
        
        public Guid SupplierId { get; set; }
        
        public Supplier Supplier { get; set; }
    }
}
