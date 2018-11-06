using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Animal
    {
        protected string name;
        protected string species;

        public Animal(string AnimalName)
        {
            name = AnimalName;
        }

        public void Eat()
        {

        }

        public string GetName()
        {
            return name;
        }
        
        public string GetSpecies()
        {
            return species;
        }
    }
}
