using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace hello_world
{
    class Zoop
    {
        private string welcome;
        private Animal giraffe;
        private Snake snake;
        private Lion lion;
        private Lion lion2;
        private Crocodile crocodile;
        private List<Animal> animals;
        private int numberOfAnimals;
           
        public Zoop()
        {
            welcome = "Welcome too the Zoo";
            animals = new List<Animal>();
            createAnimals();
            addAnimals();
            numberOfAnimals = animals.Count();
        }

        public void PrintWelcome()
        {
            Console.WriteLine(welcome);
            Console.WriteLine("We have "+ numberOfAnimals + " animals in this zoo:");
            Thread.Sleep(2000);
            for (int i = 0; i < numberOfAnimals; i++)
            {
                Console.WriteLine("We have " + animals[i].GetName() + " the " + animals[i].GetSpecies());
                Thread.Sleep(2000);
            }
            Console.ReadLine();
        }

        public void addAnimals()
        {
            animals.Add(giraffe);
            animals.Add(snake);
            animals.Add(lion);
            animals.Add(lion2);
            animals.Add(crocodile);
        }

        public void createAnimals()
        {
            giraffe = new Giraffe("Gerry");
            snake = new Snake("Sneaky Little Snake");
            lion = new Lion("Simba");
            lion2 = new Lion("Nala");
            crocodile = new Crocodile("Dundee");
        }
    }
}
