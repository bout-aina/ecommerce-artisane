﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artisanaux.Services.ProductAPI.Models
{
    [Table("Products")]
    public class Product
    {   //prop double tabulation
        [Key]
        public int ProductId { get; set; }
        [Required,StringLength(25)]
        public string ProductName  { get; set; }
        [Range(1,1000)]
        public Double Price { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
    }
}