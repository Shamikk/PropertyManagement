using System;
using System.Collections.Generic;
using System.Text;
using PropertyManagement.BLL.Entities;

namespace PropertyManagement.BLL.Services
{
    public class PropertyService : IPropertyService
    {
        public House CreateProperty(Human owner, Human seller, House house, Address address)
        {
            return new House
            {
                Owner = owner,
                Address = address,
                Area = house.Area,
                Description = house.Description,
                HasGarrage = house.HasGarrage,
                Levels = house.Levels,
                Price = house.Price,
                Rooms = house.Rooms,
                Seller = seller
            };
        }

        public Appartment CreateProperty(Human owner, Human seller, Appartment appartment, Address address)
        {
            return new Appartment
            {
                Address = appartment.Address,
                Area = appartment.Area,
                Description = appartment.Description,
                Floor = appartment.Floor,
                Levels = appartment.Levels,
                Owner = owner,
                Price = appartment.Price,
                Rooms = appartment.Rooms,
                Seller = seller
            };
        }

        public Ground CreateProperty(Human owner, Human seller, Ground ground, Address address)
        {
            return new Ground
            {
                Address = address,
                Area = ground.Area,
                Description = ground.Description,
                HasGas = ground.HasGas,
                HasPower = ground.HasPower,
                HasTrees = ground.HasTrees,
                HasWater = ground.HasWater,
                Owner = owner,
                Price = ground.Price,
                Seller = seller
            };
        }
    }
}
