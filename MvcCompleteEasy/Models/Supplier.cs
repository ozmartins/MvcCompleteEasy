﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCompleteEasy.Models
{
    public class Supplier : Entity
    {
        public string Name { get; set; }
        public string DocumentId { get; set; }
        public DocumentType DocumentType { get; set; }
        public Address Address { get; set; }
        public bool Active { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
