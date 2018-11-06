using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    abstract class Duck
    {
        protected FlyBehaviour flyBehaviour;
        protected QuackBehaviour quackBehaviour;


        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }

        public void SetFlyBehaviour(FlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void setQuackBehaviour(QuackBehaviour qb)
        {
            quackBehaviour = qb;
        }

    }
}
