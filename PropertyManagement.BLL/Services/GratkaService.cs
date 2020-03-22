using System;
using System.Collections.Generic;
using System.Text;
using PropertyManagement.BLL.Dtos;
using PropertyManagement.BLL.Entities;

namespace PropertyManagement.BLL.Services
{
    public class GratkaService : IGratkaOfferApi
    {
        public GratkaOfferDto CreateOffer(House house, UserDetailsDto ownerDetails, UserDetailsDto sellerDetails)
        {
            var offer = new GratkaOfferDto();
            offer.City = house.Address.City;
            offer.OwnerEmail = house.Owner.Email;
            offer.OwnerFirstName = house.Owner.FirstName;
            offer.Price = house.Price;
            offer.StreetName = house.Address.StreetName;
            offer.StreetNumber = house.Address.StreetNumber;

            return offer;
        }
            

        
        public bool Send(GratkaOfferDto offer)
        {
            return true;
        }
    }
}
