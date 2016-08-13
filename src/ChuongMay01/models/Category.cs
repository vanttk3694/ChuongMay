using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChuongMay01.models
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public int CategoryParentId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryUrl { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
