using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    abstract class Reptile: Animal
    {
        public Reptile(string AnimalName)
            :base(AnimalName)
        {

        }

        public void WarmUp()
        {

        }
    }
}
