using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyManagement.BLL.Dtos
{
    public class GratkaOfferDto
    {
        public string City { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public float Price { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerEmail { get; set; }
    }
}
