using System;

namespace PropertyManagement.BLL.Entities
{
    public class Property
    {
        public Address Address { get; set; }
        public float Price { get; set; }
        public Human Owner { get; set; }
        public Human Seller { get; set; }
        public float Area { get; set; }
        public string Description { get; set; }
    }
}
