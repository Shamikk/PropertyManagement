using PropertyManagement.BLL.Dtos;
using PropertyManagement.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyManagement.BLL.Services
{
    public interface IGratkaOfferApi
    {
        GratkaOfferDto CreateOffer(House house);
    }
}
