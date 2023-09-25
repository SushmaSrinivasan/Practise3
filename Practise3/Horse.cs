using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
     class Horse : Animal
    {
        public string Color { get; set; }

        public Horse(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = "white";

        }
        public override void DoSound()
        {
            Console.WriteLine($"{Name} whinnes..");
        }

        public override string Stats()
        {
            return base.Stats() + $"Color of Horse:{Color}";
        }
    }
}
