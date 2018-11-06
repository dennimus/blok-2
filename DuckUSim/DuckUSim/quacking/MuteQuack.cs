using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    class MuteQuack:QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("<<silence>>");
        }
    }
}
