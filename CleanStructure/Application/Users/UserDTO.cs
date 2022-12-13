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
        private string phone;

        public Guid Id { get; private set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime BirthDay { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public string Phone { get { return phone; } set { phone = this.FormatPhoneNumber(value); } }

        public Role Role { get; set; }

        public virtual List<Activity> Activities { get; private set; }

        public UserDTO()
        {
            Id = Guid.NewGuid();
        }

        public UserDTO(string firstName, string lastName, string email, string password, Role role)
        {
            Id = Guid.NewGuid();
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Password = password;
            Role = role;
            Activities = new List<Activity>();
        }

        public UserDTO(string firstName, string lastName, string email, string password, string phone, Role role) : this(firstName, lastName, email, password, role)
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

        public UserDTO(string firstName, string lastName, string email, string password, DateTime date, double height, double weight, Role role) : this(firstName, lastName, email, password, role)
        {
            BirthDay = date;
            Height = height;
            Weight = weight;
        }

        public UserDTO(string firstName, string lastName, string email, string password, DateTime date, double height, double weight, string phone, Role role) : this(firstName, lastName, email, password, date, height, weight, role)
        {
            Phone = phone;
        }

        public string FormatPhoneNumber(string phone)
        {
            Regex regex = new Regex(@"[^\d]");
            phone = regex.Replace(phone, "");
            phone = Regex.Replace(phone, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            return phone;
        }
    }
}
