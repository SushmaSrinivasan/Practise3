using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise3
{
    class Flamingo : Bird
    {
        public double legLength { get; set; }

        public Flamingo(string name, int age, double weight) : base(name, age, weight)
        {
            legLength = 12.5;
        }

        public override string stats()
        {
            return base.stats() + $"LegLength:{legLength}";
        }
    }
}
