using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyManagement.BLL.Entities
{
    public class Offer
    {
        public Human Bidder { get; set; }
        public House House { get; set; }
        public float OfferedPrice { get; set; }
    }
}
