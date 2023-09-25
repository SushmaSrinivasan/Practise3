using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
    class Swan : Bird
    {
        public int Feathers{ get; set; }

        public Swan(string name, int age, double weight):base(name, age, weight) 
        {
            Feathers = 1500;
        }

        public override string Stats()
        {
            return base.Stats() + $"Number of Feathers:{Feathers}";
        }

    }
}
