using System;
using System.Collections.Generic;

namespace NorthwindowDemo.DomainModel.Models
{
    public class Region
    {
        public Region()
        {
            this.Territories = new List<Territory>();
        }

        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
