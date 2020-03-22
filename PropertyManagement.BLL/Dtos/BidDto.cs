using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyManagement.BLL.Dtos
{
    public class BidDto
    {
        public UserDetailsDto Bidder { get; set; }
        public float OfferedPrice { get; set; }
        public GratkaOfferDto Offer { get; set; }
    }
}
