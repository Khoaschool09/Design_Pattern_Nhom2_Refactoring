﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_ChangeUnidirectionalAssociationtoBidirectional_24
{
    public class Customer
    {
        public string Name { get; set; }
        public Customer(string name)
        {
            Name = name;
        }
    }
}
