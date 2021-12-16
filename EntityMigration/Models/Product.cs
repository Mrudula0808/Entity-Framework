﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityMigration.Models
{
    public class Product
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

    }
}
