using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NorthwindowDemo.DomainModel.Models
{
    [Serializable]
    [DataContract]
    public class Category
    {
        public Category()
        {
            this.Products = new List<Product>();
        }

        [DataMember]
        public int CategoryID { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public byte[] Picture { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
