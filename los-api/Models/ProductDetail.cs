using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace los_api.Models
{
    public class ProductDetail
    {
        public string ProductID { get; set; }
        public string Productname { get; set; }
        public string imageUrl { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> amount { get; set; }
    }
}