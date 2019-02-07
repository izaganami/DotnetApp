using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.Models
{
    public class Type
    {
        [Key]
        [ScaffoldColumn(false)]//allows hiding fields from editor forms
        public int TypeId { get; set; }
        [DisplayName("Product")]
        public int ProductId { get; set; }
        [DisplayName("Brand")]
        public int BrandId { get; set; }
        [Required(ErrorMessage = "A Title is required")]
        [StringLength(100)]
        public string Title { get; set; }
        [Range(0.01, 20000.00,
            ErrorMessage = "Price must be between 0.01 and 20000.00")]
        public decimal Price { get; set; }
        [DisplayName("Image Art URL")]
        [StringLength(1024)]
        public string TypeArtUrl { get; set; }
        //virtual => Lazy loading For entity
        public virtual Product Product { get; set; }
        public virtual Brand Brand { get; set; }
    }
}