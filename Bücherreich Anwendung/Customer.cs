﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Bücherreich_Anwendung
{
    public class Customer
    {
        // Properties
        public int Id { get; private set; }
        public string Name { get; set; }

        // Konstruktor
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
