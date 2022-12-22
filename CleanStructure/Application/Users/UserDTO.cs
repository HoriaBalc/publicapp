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


        public UserDTO()
        {
            Id = Guid.NewGuid();
        }

        public UserDTO(string firstName, string lastName, string email, string password)
        {
            Id = Guid.NewGuid();
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Password = password;
           
        }

        public UserDTO(string firstName, string lastName, string email, string password, string phone) : this(firstName, lastName, email, password)
        {
            Phone = phone;
        }

        //public User(string firstName, string lastName, string email, string role, string phone)
        //{
        //    Id = Guid.NewGuid();
        //    LastName = lastName;
        //    FirstName = firstName;
        //    Email = email;
        //    Role = new Role(role);
        //    Phone = phone;
        //}

        public UserDTO(string firstName, string lastName, string email, string password, DateTime date, double height, double weight) : this(firstName, lastName, email, password)
        {
            BirthDay = date;
            Height = height;
            Weight = weight;
        }

        public UserDTO(string firstName, string lastName, string email, string password, DateTime date, double height, double weight, string phone) : this(firstName, lastName, email, password, date, height, weight)
        {
            Phone = phone;
        }

         
    }
}
