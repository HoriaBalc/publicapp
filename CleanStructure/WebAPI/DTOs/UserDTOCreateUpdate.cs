namespace WebAPI.DTOs
{
    public class UserDTOCreateUpdate
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string RoleName { get; set; }
        public string Phone { get; set; }

        public UserDTOCreateUpdate(string firstName, string lastName, string email, string password, DateTime date, double height, double weight, string roleName, string phone)
        {            
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            BirthDay = date;
            Height = height;
            Weight = weight;
            RoleName = roleName;
            Phone = phone;
        }

        
    }
}
