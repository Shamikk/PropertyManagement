using PropertyManagement.BLL.Dtos;
using PropertyManagement.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyManagement.BLL.Services
{
    public class BidService : IBidService
    {
        public Offer GetOffer(BidDto bid)
        {
            var offer = new Offer();

            offer.OfferedPrice = bid.OfferedPrice;
            offer.Bidder = new Human();
            offer.Bidder.Email = bid.Bidder.Email;

            var names = bid.Bidder.FullName.Split(' ');
            offer.Bidder.FirstName = names[0];
            offer.Bidder.LastName = names[1];

            offer.House = new House();
            offer.House.Address = new Address();

            
            offer.House.Address.City = bid.Offer.City;
            offer.House.Address.StreetName = bid.Offer.StreetName;
            offer.House.Address.StreetNumber = bid.Offer.StreetNumber;

            offer.House.Price = bid.Offer.Price;

            return offer;

        }
    }
}
