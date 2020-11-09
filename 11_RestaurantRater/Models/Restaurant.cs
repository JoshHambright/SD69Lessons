﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _11_RestaurantRater.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double Rating { get; set; }
    }
}