﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sport
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Sport(string name) {
            Id = new Guid();
            Name = name;
        }

    }
}
