﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Lion:Mammel
    {
        public Lion(string LionName)
           : base(LionName)
        {
            species = "Lion";
        }
    }
}
