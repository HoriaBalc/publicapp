using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class UserDTOCreateUpdate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string RoleName { get; set; }
        public string Phone { get; set; }

        
    }
}
