using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
     class Horse : Animal
    {
        public string color { get; set; }

        public Horse(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            color = "white";

        }
        public override void DoSound()
        {
            Console.WriteLine($"{Name} whinnes..");
        }

        public override string stats()
        {
            return base.stats() + $"Color of Horse:{color}";
        }
    }
}
