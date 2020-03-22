using PropertyManagement.BLL.Dtos;
using PropertyManagement.BLL.Entities;
using PropertyManagement.BLL.Services;
using System;

namespace PropertyManagement.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address
            {
                City = "Warsaw",
                Country = "Poland",
                StreetName = "Marszałkowska",
                StreetNumber = "10"
            };

            var owner = new Human
            {
                Age = 30,
                Description = "Seems like he want's to buy.",
                Email = "someone@example.com",
                FirstName = "Jan",
                LastName = "Kowalski"
            };

            var seller = new Human
            {
                Age = 52,
                Email = "seller1@example.com",
                FirstName = "Marian",
                LastName = "Maliniak"
            };

            var house = new House
            {
                Area = 82.4f,
                Description = "Nice, sunny appartment in center of Warsaw.",
                Rooms = 4,
                HasGarrage = false,
                Levels = 1,
                Price = 600000f
            };

            var propertyService = new PropertyService();
            var property = propertyService.CreateProperty(owner, seller, house, address);
            var gradkaService = new GratkaService();
            
            

            var humanService = new HumanServicec();
            var sellerDetails = humanService.CreateNewUserDetails(seller, BLL.Dtos.Role.SELLER);
            var ownerDetails = humanService.CreateNewUserDetails(owner, BLL.Dtos.Role.OWNER);

            var offer = gradkaService.CreateOffer(property, ownerDetails, sellerDetails);
            var isSent = gradkaService.Send(offer);
            if(isSent == true)
            {
                System.Console.WriteLine("We are send the offer");
            } else
            {
                System.Console.WriteLine("We did not sent the offer");
            }

            System.Console.WriteLine(offer.City);
            System.Console.WriteLine($"Owner detail is {ownerDetails.FullName}.");
            System.Console.WriteLine($"Seller detail is {sellerDetails.FullName}.");


            var bidDto = new BidDto();
            bidDto.OfferedPrice = 700000;

            bidDto.Bidder = new UserDetailsDto();
            bidDto.Bidder.Email = "kowalski@gmail.com";
            bidDto.Bidder.FullName = "Jan Kowalski";
            bidDto.Bidder.Role = Role.UNDEFINED;

            bidDto.Offer = new GratkaOfferDto();
            bidDto.Offer.City = "Gdansk";
            bidDto.Offer.Price = 650000;
            bidDto.Offer.StreetName = "Warszawska";
            bidDto.Offer.StreetNumber = "22";


            var bidService = new BidService();
            var clientOffer =  bidService.GetOffer(bidDto);

            System.Console.WriteLine($"Dom na sprzedaz jest w miescie {clientOffer.House.Address.City}");


        }
    }
}
