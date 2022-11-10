using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Role
    {   
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Role(string name) {
            Id = Guid.NewGuid();
            Name = name;
        }

    }
}
