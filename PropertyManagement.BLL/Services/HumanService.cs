using PropertyManagement.BLL.Dtos;
using PropertyManagement.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyManagement.BLL.Services
{
    public class HumanServicec : IHunanService
    {
        public UserDetailsDto CreateNewUserDetails(Human human, Role role)
        {
            var userDetails = new UserDetailsDto();

            userDetails.FullName = $"{human.FirstName} {human.LastName}";
            userDetails.Role = role;
            userDetails.Email = human.Email;

            return userDetails;
        }
    }
}
