using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Role
    {   
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<User> Users { get; private set; }

        public Role(string name) {
            Id = Guid.NewGuid();
            Name = name;
            Users = new List<User>();
        }

    }
}
