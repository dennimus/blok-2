using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    class MallardDuck:Duck
    {
        public MallardDuck()
        {
            quackBehaviour = new Quacks();
            flyBehaviour = new FlyWithWings();
        }

        public void Display()
        {
            Console.WriteLine("I'm a reall Mallard duck");
        }
    }
}
