using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Crocodile:Reptile
    {
        public Crocodile(string CrocodileName)
           : base(CrocodileName)
        {
            species = "Crocodile";
        }

    }
}
