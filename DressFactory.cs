﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class DressFactory 
    {
        public abstract Shirt GetShirt();
        public abstract Trouser GetTrouser();
    }
}
