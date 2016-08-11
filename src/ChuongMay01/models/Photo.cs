using System;
using System.Collections.Generic;

namespace ChuongMay01.models
{
    public partial class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoUrl { get; set; }
        public int? ProductId { get; set; }
        public int? NewsId { get; set; }

        public virtual News News { get; set; }
        public virtual Product Product { get; set; }
    }
}
