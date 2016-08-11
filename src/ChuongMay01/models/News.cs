using System;
using System.Collections.Generic;

namespace ChuongMay01.models
{
    public partial class News
    {
        public News()
        {
            Photo = new HashSet<Photo>();
        }

        public int NewsId { get; set; }
        public string NewsContent { get; set; }
        public string NewsUrl { get; set; }
        public int? ManagerId { get; set; }

        public virtual ICollection<Photo> Photo { get; set; }
        public virtual Manager Manager { get; set; }
    }
}
