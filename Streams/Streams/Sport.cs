using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    public class Sport
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public Sport(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }   
    }
}
