using System;
using System.Collections.Generic;

namespace ChuongMay01.models
{
    public partial class Product
    {
        public Product()
        {
            Photo = new HashSet<Photo>();
        }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductInfo { get; set; }
        public int? ProductPrice { get; set; }
        public string ProductUrl { get; set; }

        public virtual ICollection<Photo> Photo { get; set; }
        public virtual Category Category { get; set; }
    }
}
