using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
    class Bird : Animal
    {
        public double WingSpan{ get; set; }

        public Bird(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = 3.0;
        }
        public override void DoSound()
        {
            Console.WriteLine($"{Name} chirps..");
        }

        ////13. All new attributes of Bird to be added in this Bird class

        public override string stats()
        {
            return base.stats() + $"WingSpan:{WingSpan}";
        }
    }
}
