using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCompleteEasy.Models
{
    public class Supplier : Entity
    {
        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(100, ErrorMessage = "The field {0} must to have between {2} and {1} characters.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [StringLength(14, ErrorMessage = "The field {0} must to have between {2} and {1} characters.", MinimumLength = 11)]
        public string DocumentId { get; set; }
        
        public DocumentType DocumentType { get; set; }
        
        public Address Address { get; set; }

        [DisplayName("Is active?")]
        public bool Active { get; set; }
        
        public IEnumerable<Product> Products { get; set; }
    }
}
