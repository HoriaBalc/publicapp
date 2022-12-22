using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class SportDTO
    {
        public SportDTO(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

    }
}
