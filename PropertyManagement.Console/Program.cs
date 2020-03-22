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

            System.Console.WriteLine(property.Address.City);
        }
    }
}
