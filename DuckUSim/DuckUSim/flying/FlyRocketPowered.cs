using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    class FlyRocketPowered:FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying with a rocket!");
        }
    }
}
