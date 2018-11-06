using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Giraffe : Mammel
    {
 
        public Giraffe(string GiraffeName)
           : base(GiraffeName)
        {
            species = "Giraffe";
        }

    }
}
