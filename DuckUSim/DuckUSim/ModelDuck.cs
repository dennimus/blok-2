using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    class ModelDuck:Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new Quacks();
        }
        
        public void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
