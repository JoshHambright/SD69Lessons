﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _12_GeneralStore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int UPC { get; set; }
        [Required]
        [Range(0,1000)]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}