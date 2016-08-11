using System;
using System.Collections.Generic;

namespace ChuongMay01.models
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public int CategoryParentId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryUrl { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
