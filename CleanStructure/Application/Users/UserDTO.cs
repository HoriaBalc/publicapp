using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Application.Users
{
    public class UserDTO
    {

        public Guid Id { get; private set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime BirthDay { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public string Phone { get; set; }

         
    }
}
