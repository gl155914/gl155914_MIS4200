﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gl155914_MIS4200.Models
{
    public class customer
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public  ICollection<order> orders { get; set; } //collections allow you to run a loop throughout the orders for each customer

    }

}