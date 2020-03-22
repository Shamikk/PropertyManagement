using PropertyManagement.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyManagement.BLL.Services
{
    public interface IPropertyService
    {
        House CreateProperty(Human owner, Human seller, House house, Address address);
        Appartment CreateProperty(Human owner, Human seller, Appartment appartment, Address address);
        Ground CreateProperty(Human owner, Human seller, Ground ground, Address address);
    }
}
