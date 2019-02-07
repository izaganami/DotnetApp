using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopApp.Models
{
    public class Cart
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; private set; }
        public string CartId { get; set; }
        public int TypeId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Type Type { get; set; }
    }
}