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

        public void Start()
        {
            Console.WriteLine(welcome);
            Console.WriteLine("We have " + numberOfAnimals + " animals in this zoo:");
            Thread.Sleep(2000);
            for (int i = 0; i < numberOfAnimals; i++)
            {
                if (i < (numberOfAnimals - 1))
                {
                    Console.WriteLine("We have " + animals[i].GetName() + " the " + animals[i].GetSpecies());
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("And finally we have " + animals[i].GetName() + " the " + animals[i].GetSpecies());
                    Thread.Sleep(2000);
                }
            }
            Console.WriteLine("if you want to hear the lion roar type roar");
            string input = Console.ReadLine();

            if (input == "roar")
            {
                int numberOfLions = 0;
                foreach (Animal animal in animals)
                {
                    if (animal.GetSpecies() == "lion")
                    numberOfLions++;
                }

                for (int i = 0; i < numberOfLions; i++)
                {
                    lion.Roar();
                }
            }
            Console.Read();
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
