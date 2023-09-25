using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
    class Wolf : Animal
    {
        public int SharpTeeth { get; set; }

        public Wolf(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            SharpTeeth = 15;
        }
        public override void DoSound()
        {
            Console.WriteLine($"{Name} Howls.");
        }

        public override string stats()
        {
            return base.stats() + $"Number of Sharp Teeths:{SharpTeeth}";
        }

    }
}
