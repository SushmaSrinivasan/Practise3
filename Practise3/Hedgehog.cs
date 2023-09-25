using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
    class Hedgehog : Animal
    {
        public int NoOfSpikes { get; set; }

        public Hedgehog(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            NoOfSpikes = 300;
        }
        public override void DoSound()
        {
            Console.WriteLine($"{Name} Squeaks..");
        }

        public override string Stats()
        {
            return base.Stats() + $"Number of Spikes:{NoOfSpikes}";
        }

    }
}
