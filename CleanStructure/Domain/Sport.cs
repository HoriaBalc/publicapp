using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sport
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<Activity> Activities { get; set; }

        public Sport(string name) {
            Id = Guid.NewGuid();
            Name = name;
            Activities = new List<Activity>();
        }

    }
}
