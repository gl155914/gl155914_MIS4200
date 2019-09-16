﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gl155914_MIS4200.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        //Product is on the "one" side of a one-to-many 
        //relationship with OrderDetail
        public  ICollection<OrderDetail> OrderDetail { get; set; }
    }
}