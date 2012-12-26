using System;
using System.Collections.Generic;

namespace NorthwindowDemo.DomainModel.Models
{
    public class Products_Above_Average_Price
    {
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}
