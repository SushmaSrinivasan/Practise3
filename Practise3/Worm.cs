using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
    class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            IsPoisonous = false;
        }
        public override void DoSound()
        {
            Console.WriteLine($"{Name} wriggles slowly");
        }

        public override string stats()
        {
            return base.stats() + $"IsPoisonous:{IsPoisonous}";
        }
    }
}
