using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Snake:Reptile
    {
        public Snake(string SnakeName)
           : base(SnakeName)
        {
            species = "Snake";
        }

    }
}
