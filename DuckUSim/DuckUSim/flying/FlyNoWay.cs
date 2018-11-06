using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
       class FlyNoWay: FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can's fly");
        }
    }
}
