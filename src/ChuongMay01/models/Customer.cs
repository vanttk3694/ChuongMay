using System;
using System.Collections.Generic;

namespace ChuongMay01.models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerFacebookId { get; set; }
        public string CustomerGoogleId { get; set; }
    }
}
