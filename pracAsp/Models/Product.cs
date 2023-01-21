using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pracAsp.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        [Required (ErrorMessage="cant be empty")]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Range (0 ,100000, ErrorMessage=" price should be between 0 to 100000")]
        public double Price { get; set; }
        [Required(ErrorMessage="cant be left empty")]
        [Range(1,1000)]
        public int Quantity { get; set; }
        
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product{Id=1, ProductName="Wall Clock", Price=899.89, Quantity=120},
                new Product{Id=2, ProductName="Table Fan", Price=2599.5, Quantity=20},
                new Product{Id=3, ProductName="Toys", Price=250, Quantity=100},
                new Product{Id=4, ProductName="Speaker", Price=12599, Quantity=80},
            };
        }
    }
}