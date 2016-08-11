using System;
using System.Collections.Generic;

namespace ChuongMay01.models
{
    public partial class Manager
    {
        public Manager()
        {
            Feedback = new HashSet<Feedback>();
            News = new HashSet<News>();
        }

        public int ManagerId { get; set; }
        public string ManagerUsername { get; set; }
        public string ManagerName { get; set; }
        public string ManagerPassword { get; set; }
        public string ManagerEmail { get; set; }
        public string ManagerPermission { get; set; }

        public virtual ICollection<Feedback> Feedback { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
