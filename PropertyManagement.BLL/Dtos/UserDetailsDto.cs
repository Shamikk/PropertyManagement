using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyManagement.BLL.Dtos
{
    public class UserDetailsDto
    {
        public string FullName { get; set; }
        public Role Role { get; set; }
        public string Email { get; set; }
    }

    public enum Role
    {
        UNDEFINED = 0,
        OWNER = 1,
        SELLER = 2
    }
}
