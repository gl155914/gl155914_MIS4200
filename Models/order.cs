using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gl155914_MIS4200.Models
{
    public class order
    {
        public int orderID { get; set; }
        public int customerID { get; set; }             // this code says its going to imbed the customer by retrieving their ID and Order Id
        public virtual customer customer { get; set; } 
              //this is where you name it               //virtual doesnt change what it does, it tells the program not to immediately bring the customer data up
        public DateTime orderDate { get; set; }
    }
}