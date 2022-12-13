using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class RoleDTO
    {
        public RoleDTO(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Users = new List<User>();
        }
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public List<User> Users { get; set; } = new();
    }
}
