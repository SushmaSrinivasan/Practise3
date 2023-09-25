using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
     class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Breed = "German Shepard";
        }
        public override void DoSound()
        {
            Console.WriteLine($"{Name} Barks...");
        }

        public override string Stats()
        {
            return base.Stats() + $"Breed:{Breed}";
        }

        public string RandomMethod()
        {
            return "This is simply a method";
        }
    }
}
