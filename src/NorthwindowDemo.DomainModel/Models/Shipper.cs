using System;
using System.Collections.Generic;

namespace NorthwindowDemo.DomainModel.Models
{
    public class Shipper
    {
        public Shipper()
        {
            this.Orders = new List<Order>();
        }

        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
