﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern._2
{
    public abstract class Developer
    {
        public string? Name { get; set; }

        public Developer(string? name)
        {
            Name = name;
        }

        abstract public House Create();
    }
}
