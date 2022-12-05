﻿using System;
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

        public Sport(string name) {
            Id = Guid.NewGuid();
            Name = name;
        }

    }
}
